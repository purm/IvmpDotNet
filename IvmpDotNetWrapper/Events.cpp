#include "SDK\SDK.h"
#include "Events.h"

void RegisterEvents() {
	//Server Events
	IVMP::Events::Manager()->AddModuleEvent("serverPulse", event_serverPulse);
	IVMP::Events::Manager()->AddModuleEvent("consoleInput", event_consoleInput);
	IVMP::Events::Manager()->AddModuleEvent("consoleOutput", event_consoleOutput);

	//Player Events
	IVMP::Events::Manager()->AddModuleEvent("playerSpawn", event_playerSpawn);
	IVMP::Events::Manager()->AddModuleEvent("playerCommand", event_playerCommand);
}

void event_serverPulse(SquirrelArgumentsInterface* pArguments, SquirrelArgumentInterface* pReturn, void* pChunk) {
	pReturn->SetInteger(IvmpDotNet::IvmpDotNetCore::Singleton->EventHandler->RaiseServerPulse());
}

void event_consoleInput(SquirrelArgumentsInterface* pArguments, SquirrelArgumentInterface* pReturn, void* pChunk) {
	pReturn->SetInteger(IvmpDotNet::IvmpDotNetCore::Singleton->EventHandler->RaiseConsoleInput(gcnew System::String(pArguments->Get(0)->GetString())));
}

void event_consoleOutput(SquirrelArgumentsInterface* pArguments, SquirrelArgumentInterface* pReturn, void* pChunk) {
	pReturn->SetInteger(IvmpDotNet::IvmpDotNetCore::Singleton->EventHandler->RaiseConsoleOutput(gcnew System::String(pArguments->Get(0)->GetString())));
}

void event_playerSpawn(SquirrelArgumentsInterface* pArguments, SquirrelArgumentInterface* pReturn, void* pChunk) {
	pReturn->SetInteger(IvmpDotNet::IvmpDotNetCore::Singleton->EventHandler->RaisePlayerSpawn(pArguments->Get(0)->GetInteger()));
}

void event_playerCommand(SquirrelArgumentsInterface* pArguments, SquirrelArgumentInterface* pReturn, void* pChunk) {
	pReturn->SetInteger(IvmpDotNet::IvmpDotNetCore::Singleton->EventHandler->RaisePlayerCommand(pArguments->Get(0)->GetInteger(), gcnew System::String(pArguments->Get(1)->GetString())));
}