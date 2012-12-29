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

	static void RaiseServerPulse() {
		SetReturnValue(IvmpDotNetCore::Singleton->EventHandler->RaiseServerPulse());
	}

	static void RaiseConsoleInput() {
		SetReturnValue(IvmpDotNetCore::Singleton->EventHandler->RaiseConsoleInput(
			(System::String^)System::AppDomain::CurrentDomain->GetData("_EVENT_PARAM_1")));
	}

	static void RaiseConsoleOutput() {
		SetReturnValue(IvmpDotNetCore::Singleton->EventHandler->RaiseConsoleOutput(
			(System::String^)System::AppDomain::CurrentDomain->GetData("_EVENT_PARAM_1")));
	}

	static void RaisePlayerSpawn() {
		SetReturnValue(IvmpDotNetCore::Singleton->EventHandler->RaisePlayerSpawn(
			(int)System::AppDomain::CurrentDomain->GetData("_EVENT_PARAM_1")));
	}

	static void RaisePlayerCommand() {
		SetReturnValue(IvmpDotNetCore::Singleton->EventHandler->RaisePlayerCommand(
			(int)System::AppDomain::CurrentDomain->GetData("_EVENT_PARAM_1"), 
			(System::String^)System::AppDomain::CurrentDomain->GetData("_EVENT_PARAM_2")));
	}
};

void RegisterEvents() { 
	EventRegisterManager::RegisterEvents();
}

inline bool ExistsModuleDomain(SquirrelArgumentInterface* pReturn) {
	return IvmpDotNet::Core::IvmpDotNetCore::Singleton->ModuleLoader->ModuleDomain != nullptr;
}

void event_serverPulse(SquirrelArgumentsInterface* pArguments, SquirrelArgumentInterface* pReturn, void* pChunk) {
	if(!ExistsModuleDomain(pReturn)) {
		pReturn->SetInteger(1);
		return;
	}

	IvmpDotNet::Core::IvmpDotNetCore::Singleton->ModuleLoader->ModuleDomain->DoCallBack(gcnew System::CrossAppDomainDelegate(EventRegisterManager::RaiseServerPulse));

	pReturn->SetInteger(EventRegisterManager::GetReturnData());
}

void event_consoleInput(SquirrelArgumentsInterface* pArguments, SquirrelArgumentInterface* pReturn, void* pChunk) {
	System::String^ text = gcnew System::String(pArguments->Get(0)->GetString());

	//Call this event also in default appDomain, so that it can be handled internally
	System::AppDomain::CurrentDomain->SetData("_EVENT_PARAM_1", text);
	EventRegisterManager::RaiseConsoleInput();

	if(!ExistsModuleDomain(pReturn)) {
		pReturn->SetInteger(1);
		return;
	}

	//Call in Module-Appdomain
	IvmpDotNetCore::Singleton->ModuleLoader->ModuleDomain->SetData("_EVENT_PARAM_1", text);
	IvmpDotNet::Core::IvmpDotNetCore::Singleton->ModuleLoader->ModuleDomain->DoCallBack(gcnew System::CrossAppDomainDelegate(EventRegisterManager::RaiseConsoleInput));

	pReturn->SetInteger(EventRegisterManager::GetReturnData());
}

void event_consoleOutput(SquirrelArgumentsInterface* pArguments, SquirrelArgumentInterface* pReturn, void* pChunk) {
	if(!ExistsModuleDomain(pReturn)) {
		pReturn->SetInteger(1);
		return;
	}

	IvmpDotNetCore::Singleton->ModuleLoader->ModuleDomain->SetData("_EVENT_PARAM_1", gcnew System::String(pArguments->Get(0)->GetString()));
	IvmpDotNet::Core::IvmpDotNetCore::Singleton->ModuleLoader->ModuleDomain->DoCallBack(gcnew System::CrossAppDomainDelegate(EventRegisterManager::RaiseConsoleOutput));

	pReturn->SetInteger(EventRegisterManager::GetReturnData());
}

void event_playerSpawn(SquirrelArgumentsInterface* pArguments, SquirrelArgumentInterface* pReturn, void* pChunk) {
	if(!ExistsModuleDomain(pReturn)) {
		pReturn->SetInteger(1);
		return;
	}

	IvmpDotNetCore::Singleton->ModuleLoader->ModuleDomain->SetData("_EVENT_PARAM_1", pArguments->Get(0)->GetInteger());
	IvmpDotNet::Core::IvmpDotNetCore::Singleton->ModuleLoader->ModuleDomain->DoCallBack(gcnew System::CrossAppDomainDelegate(EventRegisterManager::RaisePlayerSpawn));

	pReturn->SetInteger(EventRegisterManager::GetReturnData());
}

void event_playerCommand(SquirrelArgumentsInterface* pArguments, SquirrelArgumentInterface* pReturn, void* pChunk) {
	if(!ExistsModuleDomain(pReturn)) {
		pReturn->SetInteger(1);
		return;
	}

	IvmpDotNetCore::Singleton->ModuleLoader->ModuleDomain->SetData("_EVENT_PARAM_1", pArguments->Get(0)->GetInteger());
	IvmpDotNetCore::Singleton->ModuleLoader->ModuleDomain->SetData("_EVENT_PARAM_2", gcnew System::String(pArguments->Get(1)->GetString()));
	IvmpDotNet::Core::IvmpDotNetCore::Singleton->ModuleLoader->ModuleDomain->DoCallBack(gcnew System::CrossAppDomainDelegate(EventRegisterManager::RaisePlayerCommand));

	pReturn->SetInteger(EventRegisterManager::GetReturnData());
}