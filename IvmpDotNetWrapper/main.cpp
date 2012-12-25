#include "StdAfx.h"

#include <stdio.h>
#include <string.h>
#include "SDK\SDK.h"

FuncContainer_t FuncContainer;
InterfaceContainer_t InterfaceContainer;

System::Void CallingFunction(System::Object ^source, IvmpDotNet::CallingFunctionEventArgs ^e) 
{ 

}

EXPORT bool InitModule(char* szModuleName)
{
	System::String^ modName;
	bool res = IvmpDotNet::IvmpDotNet::Singleton->InitModule(modName);

	System::IntPtr p = System::Runtime::InteropServices::Marshal::StringToHGlobalAnsi(modName);
	const char* linkStr = static_cast<char*>(p.ToPointer());

	strcpy(szModuleName, linkStr);

	IvmpDotNet::IvmpDotNet::Singleton->CallingFunction += gcnew IvmpDotNet::CallingFunctionEventHandler(CallingFunction);
	
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

EXPORT void SetupFunctions(FuncContainer_t * pContainer) {
	FuncContainer = *pContainer;

	IvmpDotNet::IvmpDotNet::Singleton->SetupFunctions();
}

EXPORT void SetupInterfaces(InterfaceContainer_t * pContainer) {
	InterfaceContainer = *pContainer;
	//InterfaceContainer.g_pVehicleManager->Add(65, CVector3(-343.447662f, 1176.119263f, 14.146016f), CVector3(0.0f, 0.0f, 268.219513f), 0, 0, 0, 0, 1);
	IvmpDotNet::IvmpDotNet::Singleton->SetupInterfaces();
}

EXPORT void SetupNewInterfaces(void* v) {
	IvmpDotNet::IvmpDotNet::Singleton->SetupNewInterfaces();
}