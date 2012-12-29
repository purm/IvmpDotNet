#include "SDK\SDK.h"
#include "Events.h"

using namespace IvmpDotNet::Core;

public ref class EventRegisterManager
{
private:
	static mscoree::CorRuntimeHost^ host = gcnew mscoree::CorRuntimeHostClass();

	//Gets the default appDomain
	static System::AppDomain^ GetDefaultAppdomain() {
		System::Object^ temp;
		host->GetDefaultDomain(temp);
		return (System::AppDomain^)temp;
	}

	static void SetReturnValue(int value) {
		if(System::AppDomain::CurrentDomain->IsDefaultAppDomain() == false)
			GetDefaultAppdomain()->SetData("_EVENT_RETURN", value);
	}
public:
	static int GetReturnData() {
		return (int)GetDefaultAppdomain()->GetData("_EVENT_RETURN");
	}

	static void RegisterEvents() {
		//Server Events
		IVMP::Events::Manager()->AddModuleEvent("serverPulse", event_serverPulse);
		IVMP::Events::Manager()->AddModuleEvent("consoleInput", event_consoleInput);
		IVMP::Events::Manager()->AddModuleEvent("consoleOutput", event_consoleOutput);

		//Player Events
		IVMP::Events::Manager()->AddModuleEvent("playerSpawn", event_playerSpawn);
		IVMP::Events::Manager()->AddModuleEvent("playerCommand", event_playerCommand);
	}

	static void RaiseConsoleInput() {
		SetReturnValue(IvmpDotNetCore::Singleton->EventHandler->RaiseConsoleInput((System::String^)System::AppDomain::CurrentDomain->GetData("_EVENT_PARAM_1")));
	}
};

void RegisterEvents() { 
	EventRegisterManager::RegisterEvents();
}

void event_serverPulse(SquirrelArgumentsInterface* pArguments, SquirrelArgumentInterface* pReturn, void* pChunk) {
	pReturn->SetInteger(IvmpDotNetCore::Singleton->EventHandler->RaiseServerPulse());
}

void event_consoleInput(SquirrelArgumentsInterface* pArguments, SquirrelArgumentInterface* pReturn, void* pChunk) {
	System::String^ text = gcnew System::String(pArguments->Get(0)->GetString());

	//Set Parameters
	IvmpDotNetCore::Singleton->ModuleLoader->ModuleDomain->SetData("_EVENT_PARAM_1", text);
	System::AppDomain::CurrentDomain->SetData("_EVENT_PARAM_1", text);

	//Call in Module-Appdomain
	IvmpDotNet::Core::IvmpDotNetCore::Singleton->ModuleLoader->ModuleDomain->DoCallBack(gcnew System::CrossAppDomainDelegate(EventRegisterManager::RaiseConsoleInput));

	//Call this event also in default appDomain, so that it can be handled internally
	EventRegisterManager::RaiseConsoleInput();

	pReturn->SetInteger(EventRegisterManager::GetReturnData());
}

void event_consoleOutput(SquirrelArgumentsInterface* pArguments, SquirrelArgumentInterface* pReturn, void* pChunk) {
	pReturn->SetInteger(IvmpDotNetCore::Singleton->EventHandler->RaiseConsoleOutput(gcnew System::String(pArguments->Get(0)->GetString())));
}

void event_playerSpawn(SquirrelArgumentsInterface* pArguments, SquirrelArgumentInterface* pReturn, void* pChunk) {
	pReturn->SetInteger(IvmpDotNetCore::Singleton->EventHandler->RaisePlayerSpawn(pArguments->Get(0)->GetInteger()));
}

void event_playerCommand(SquirrelArgumentsInterface* pArguments, SquirrelArgumentInterface* pReturn, void* pChunk) {
	pReturn->SetInteger(IvmpDotNetCore::Singleton->EventHandler->RaisePlayerCommand(pArguments->Get(0)->GetInteger(), gcnew System::String(pArguments->Get(1)->GetString())));
}