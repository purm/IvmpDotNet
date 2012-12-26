#include "StdAfx.h"

#include <stdio.h>
#include <string.h>
#include "SDK/SDK.h"

InterfaceContainer_t InterfaceContainer;
NewInterfaceContainer_t NewInterfaceContainer;
FuncContainer_t FuncContainer;

EXPORT bool InitModule(char* szModuleName)
{
	System::String^ modName;
	bool res = IvmpDotNet::IvmpDotNet::Singleton->InitModule(modName);

	System::IntPtr p = System::Runtime::InteropServices::Marshal::StringToHGlobalAnsi(modName);
	const char* linkStr = static_cast<char*>(p.ToPointer());

	strcpy(szModuleName, linkStr);

	return res;
}

EXPORT void ScriptLoad(HSQUIRRELVM v)
{
	IvmpDotNet::IvmpDotNet::Singleton->ScriptLoad();
}

EXPORT void ScriptUnload(HSQUIRRELVM pVM)
{
	IvmpDotNet::IvmpDotNet::Singleton->ScriptLoad();
}

EXPORT void Pulse()
{
	IvmpDotNet::IvmpDotNet::Singleton->Pulse();
}

EXPORT void SetupFunctions(FuncContainer_t* pContainer) {
	FuncContainer = *pContainer;

	IvmpDotNet::IvmpDotNet::Singleton->SetupFunctions();
}

EXPORT void SetupInterfaces(InterfaceContainer_t * pContainer) {
	InterfaceContainer = *pContainer;

	IvmpDotNet::IvmpDotNet::Singleton->SetupInterfaces();
}

EXPORT void SetupNewInterfaces(NewInterfaceContainer_t * pContainer) {
	NewInterfaceContainer = *pContainer;

	IvmpDotNet::IvmpDotNet::Singleton->SetupNewInterfaces();
}