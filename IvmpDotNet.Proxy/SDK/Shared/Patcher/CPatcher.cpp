//============== IV: Multiplayer - http://code.iv-multiplayer.com ==============
//
// File: CPatcher.cpp
// Project: Shared
// Author(s): jenksta
//            Azorbix
// License: See LICENSE in root directory
//
//==============================================================================

#include "CPatcher.h"
#include <malloc.h>
#ifndef WIN32
#include <sys/mman.h>
#ifndef PAGESIZE
#define PAGESIZE 4096
#endif
#endif

ProtectionInfo CPatcher::Unprotect(DWORD dwAddress, int iSize)
{
	ProtectionInfo protectionInfo;
	protectionInfo.dwAddress = dwAddress;
	protectionInfo.iSize = iSize;
#ifdef WIN32
	VirtualProtect((void *)dwAddress, iSize, PAGE_EXECUTE_READWRITE, &protectionInfo.dwOldProtection);
#else
	mprotect((void *)((dwAddress / PAGESIZE) * PAGESIZE), PAGESIZE, (PROT_EXEC | PROT_READ | PROT_WRITE));
#endif
	return protectionInfo;
}

void CPatcher::Reprotect(ProtectionInfo protectionInfo)
{
#ifdef WIN32
	DWORD dwProtection;
	VirtualProtect((void *)protectionInfo.dwAddress, protectionInfo.iSize, protectionInfo.dwOldProtection, &dwProtection);
#else
	// Not sure how to get old protection in Protect function, so this is left blank
#endif
}

void CPatcher::InstallNopPatch(DWORD dwAddress, int iSize)
{
	DWORD dwAddr = dwAddress;

	// Unprotect the address memory
	ProtectionInfo protectionInfo = Unprotect(dwAddr, iSize);

	// Write the no operation to the address memory
	memset((void *)dwAddr, X86_NOP, iSize);

	// Re-protect the address memory
	Reprotect(protectionInfo);
}

void * CPatcher::InstallDetourPatchInternal(DWORD dwAddress, DWORD dwDetourAddress, BYTE byteType, int iSize)
{
	// Allocate the trampoline memory
	BYTE * pbyteTrampoline = (BYTE *)malloc(iSize + 5);

	// Unprotect the trampoline memory
	Unprotect((DWORD)pbyteTrampoline, (iSize + 5));

	// Unprotect the address memory
	ProtectionInfo protectionInfo = Unprotect(dwAddress, (iSize + 5));

	// Copy the overwritten address memory to the trampoline memory
	memcpy(pbyteTrampoline, (void *)dwAddress, iSize);

	// Write the type to the trampoline memory
	DWORD dwTrampoline = (DWORD)(pbyteTrampoline + iSize);
	*(BYTE *)dwTrampoline = byteType;
	*(DWORD *)(dwTrampoline + 1) = ((dwAddress + iSize) - dwTrampoline - 5);

	// Write the type to the address memory
	*(BYTE *)dwAddress = byteType;
	*(DWORD *)(dwAddress + 1) = (dwDetourAddress - dwAddress - 5);

	// Re-protect the address memory
	Reprotect(protectionInfo);

	return pbyteTrampoline;
}

// TODO: A method to just use the trampoline and jmp function
void CPatcher::UninstallDetourPatchInternal(DWORD dwAddress, void * pTrampoline, int iSize)
{
	// Unprotect the address memory
	ProtectionInfo protectionInfo = Unprotect(dwAddress, iSize);

	// Copy the trampoline to the address
	memcpy((void *)dwAddress, pTrampoline, iSize);

	// Re-protect the address memory
	Reprotect(protectionInfo);

	// Free trampoline
	free(pTrampoline);
}

void * CPatcher::InstallJmpPatch(DWORD dwAddress, DWORD dwJmpAddress, int iSize)
{
	return InstallDetourPatchInternal(dwAddress, dwJmpAddress, X86_JMP, iSize);
}

void * CPatcher::InstallCallPatch(DWORD dwAddress, DWORD dwCallAddress, int iSize)
{
	return InstallDetourPatchInternal(dwAddress, dwCallAddress, X86_CALL, iSize);
}

void CPatcher::InstallRetnPatch(DWORD dwAddress)
{
	DWORD dwAddr = dwAddress;

	// Unprotect the address memory
	ProtectionInfo protectionInfo = Unprotect(dwAddr, 1);

	// Write the return to the address memory
	*(BYTE *)dwAddr = X86_RETN;

	// Re-protect the address memory
	Reprotect(protectionInfo);
}

void CPatcher::InstallStringPatch(DWORD dwAddress, char * szString, int iSize)
{
	DWORD dwAddr = dwAddress;

	// Unprotect the address memory
	ProtectionInfo protectionInfo = Unprotect(dwAddr, iSize);

	// Write the string to the address memory
	memcpy((void *)dwAddr, szString, iSize);

	// Re-protect the address memory
	Reprotect(protectionInfo);
}

void CPatcher::InstallMethodPatch(DWORD dwHookAddress, DWORD dwFunctionAddress)
{
	DWORD dwHookAddr = dwHookAddress;

	// Unprotect the address memory
	ProtectionInfo protectionInfo = Unprotect(dwHookAddr, 4);

	// Write the function to the address memory
	*(DWORD *)dwHookAddr = (DWORD)dwFunctionAddress;

	// Re-protect the address memory
	Reprotect(protectionInfo);
}

DWORD CPatcher::GetFunctionAddress(char * szLibrary, char * szFunction)
{
	return (DWORD)GetProcAddress(LoadLibrary(szLibrary), szFunction);
}

DWORD CPatcher::GetFunctionAddress(char * szLibrary, unsigned int uOrdinal)
{
	return GetFunctionAddress(szLibrary, (char *)MAKELONG(uOrdinal, 0));
}

void * CPatcher::InstallDetourPatch(char * szLibrary, char * szFunction, DWORD dwFunctionAddress)
{
	return InstallDetourPatchInternal(GetFunctionAddress(szLibrary, szFunction), dwFunctionAddress, X86_JMP, 5);
}

void * CPatcher::InstallDetourPatch(char * szLibrary, unsigned int uOrdinal, DWORD dwFunctionAddress)
{
	return InstallDetourPatchInternal(GetFunctionAddress(szLibrary, uOrdinal), dwFunctionAddress, X86_JMP, 5);
}

void CPatcher::UninstallDetourPatch(void * pTrampoline, DWORD dwFunctionAddress)
{
	// Unprotect the address memory
	ProtectionInfo protectionInfo = Unprotect(dwFunctionAddress, 5);

	// Copy the trampoline to the address
	memcpy((void *)dwFunctionAddress, pTrampoline, 5);

	// Re-protect the address memory
	Reprotect(protectionInfo);

	// Free trampoline
	free(pTrampoline);
}

BYTE CPatcher::InstallDetourPatchWithData(char * szLibrary, unsigned int uOrdinal, DWORD dwFunctionAddress)
{
	DWORD dwAddress = GetFunctionAddress(szLibrary, uOrdinal);
	DWORD dwDetourAddress = dwFunctionAddress;
	BYTE byteType = X86_JMP;
	int iSize = 5;

	// Allocate the trampoline memory
	BYTE * pbyteTrampoline = (BYTE *)malloc(iSize + 5);

	// Unprotect the trampoline memory
	Unprotect((DWORD)pbyteTrampoline, (iSize + 5));

	// Unprotect the address memory
	ProtectionInfo protectionInfo = Unprotect(dwAddress, (iSize + 5));

	// Copy the overwritten address memory to the trampoline memory
	memcpy(pbyteTrampoline, (void *)dwAddress, iSize);

	// Write the type to the trampoline memory
	DWORD dwTrampoline = (DWORD)(pbyteTrampoline + iSize);
	*(BYTE *)dwTrampoline = byteType;
	*(DWORD *)(dwTrampoline + 1) = ((dwAddress + iSize) - dwTrampoline - 5);

	// Write the type to the address memory
	*(BYTE *)dwAddress = byteType;
	*(DWORD *)(dwAddress + 1) = (dwDetourAddress - dwAddress - 5);

	// Re-protect the address memory
	Reprotect(protectionInfo);

	return (pbyteTrampoline != NULL);
}

void CPatcher::InstallPushPatch(DWORD dwAddress, DWORD dwFunc)
{
	 // Unprotect the address
	 Unprotect(dwAddress, 5);

	 // Make the call
	 *(BYTE*)(dwAddress) = 0x68;

	 // Make the call address
	 *(DWORD*)(dwAddress+1) = dwFunc; 
}

void CPatcher::InstallHookCall(DWORD dwAddr, DWORD dwFunc)
{
	 DWORD dwHookFunc = (dwFunc - (dwAddr + 5));

	 // Unprotect the address
	 Unprotect(dwAddr, 5);

	 // Make the call
	 *(BYTE*)(dwAddr) = 0xE8;

	 // Make the call address
	 *(DWORD*)(dwAddr+1) = (DWORD)dwHookFunc; 
}