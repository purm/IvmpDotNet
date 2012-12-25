#include "StdAfx.h"

#include <stdio.h>
#include <string.h>
#include "squirrel\squirrel.h"

HSQUIRRELVM vm;

void call_foo(HSQUIRRELVM v, const SQChar *s);

System::Void CallingFunction(System::Object ^source, IvmpDotNet::CallingFunctionEventArgs ^e) 
{ 
	if(vm == NULL)
		return;

	call_foo(vm, _SC("asdasdf"));

	return;

	System::IntPtr p = System::Runtime::InteropServices::Marshal::StringToHGlobalAnsi(e->FunctionName);
	const SQChar* functionName = static_cast<SQChar*>(p.ToPointer());

	int top = sq_gettop(vm); //saves the stack size before the call
	sq_pushroottable(vm); //pushes the global table
	sq_pushstring(vm,_SC("log"),-1);
	if(SQ_SUCCEEDED(sq_get(vm,-2))) { //gets the field 'foo' from the global table
			sq_pushroottable(vm); //push the 'this' (in this case is the global table)

			for each(System::Object^ param in e->Parameters) {
				System::Int32^ p = dynamic_cast<System::Int32^>(param);
				if(p != nullptr) {
					sq_pushinteger(vm, *p);
				} else {
					System::String^ pAsString = dynamic_cast<System::String^>(param);
					if(pAsString != nullptr) {
						System::IntPtr paramStringPointer = System::Runtime::InteropServices::Marshal::StringToHGlobalAnsi(pAsString);
						const SQChar* paramString = static_cast<SQChar*>(paramStringPointer.ToPointer());
						sq_pushstring(vm, paramString, -1);
					}
				}
			}

	/*		sq_pushinteger(vm,123); 
			sq_pushfloat(vm,123);
			sq_pushstring(vm,functionName,-1);*/
			sq_call(vm,e->Parameters->Count,0,0); //calls the function 
	}

	sq_settop(vm,top); //restores the original stack size
}

void call_foo(HSQUIRRELVM v, const SQChar *s)
{
	int top = sq_gettop(v); //saves the stack size before the call
	sq_pushroottable(v); //pushes the global table
	sq_pushstring(v,_SC("log"),-1);
	if(SQ_SUCCEEDED(sq_get(v,-2))) { //gets the field 'foo' from the global table
			sq_pushroottable(v); //push the 'this' (in this case is the global table)
			sq_pushstring(v,s,-1);
			sq_call(v,2,0,0); //calls the function 
	}
	sq_settop(v,top); //restores the original stack size
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
	if(v == vm) {
		
	}
	else {
		vm = v;
	}

	IvmpDotNet::IvmpDotNet::Singleton->ScriptLoad();
}

EXPORT void ScriptUnload(void* pVM)
{
	IvmpDotNet::IvmpDotNet::Singleton->ScriptLoad();
}

EXPORT void Pulse()
{
	IvmpDotNet::IvmpDotNet::Singleton->Pulse();
}

EXPORT void SetupFunctions(void* v) {
	IvmpDotNet::IvmpDotNet::Singleton->SetupFunctions();
}

EXPORT void SetupInterfaces(void* v) {
	IvmpDotNet::IvmpDotNet::Singleton->SetupInterfaces();
}

EXPORT void SetupNewInterfaces(void* v) {
	IvmpDotNet::IvmpDotNet::Singleton->SetupNewInterfaces();
}