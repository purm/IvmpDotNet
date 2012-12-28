#include "StdAfx.h"

#include <stdio.h>
#include <string.h>

#include "SDK/SDK.h"
#include "Events.h"

using namespace IvmpDotNet::Core;

InterfaceContainer_t InterfaceContainer;
NewInterfaceContainer_t NewInterfaceContainer;
FuncContainer_t FuncContainer;

//void event_playerSpawn(SquirrelArgumentsInterface* pArguments, SquirrelArgumentInterface* pReturn, void* pChunk)
//{
//	// You can see event call arguments and return on IV:MP wiki
//	// http://wiki.iv-multiplayer.com
//
//	EntityId playerId = pArguments->Get(0)->GetInteger();
//
//	LogPrintf("[ASDFFF] %s(%i) spawned...", IVMP::Players()->GetName(playerId), playerId);
//	IVMP::Players()->SendMessage(playerId, "hello from module", 0, false);	
//
//	pReturn->SetInteger(1);
//}

EXPORT bool InitModule(char* szModuleName) {
	System::String^ modName;
	bool res = IvmpDotNetCore::Singleton->InitModule(modName);

	System::IntPtr p = System::Runtime::InteropServices::Marshal::StringToHGlobalAnsi(modName);
	const char* linkStr = static_cast<char*>(p.ToPointer());

	strcpy(szModuleName, linkStr);

	RegisterEvents();

	return res;
}

EXPORT void ScriptLoad(HSQUIRRELVM v) {
	IvmpDotNetCore::Singleton->ScriptLoad();
}

EXPORT void ScriptUnload(HSQUIRRELVM pVM) {
	IvmpDotNetCore::Singleton->ScriptLoad();
}

EXPORT void Pulse() {
	IvmpDotNet::Core::IvmpDotNetCore::Singleton->Pulse();
}

EXPORT void SetupFunctions(FuncContainer_t* pContainer) {
	FuncContainer = *pContainer;

	IvmpDotNetCore::Singleton->SetupFunctions();
}

EXPORT void SetupInterfaces(InterfaceContainer_t * pContainer) {
	InterfaceContainer = *pContainer;

	IvmpDotNetCore::Singleton->SetupInterfaces();
}

EXPORT void SetupNewInterfaces(NewInterfaceContainer_t * pContainer) {
	NewInterfaceContainer = *pContainer;

	IvmpDotNetCore::Singleton->SetupNewInterfaces();
}