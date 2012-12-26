//============== Copyright � 2010 IV:MP Team. All rights reserved. ==============
// File: SDK.cpp
//===============================================================================

#include "SDK.h"

void RegisterFunction(HSQUIRRELVM pVM, const char * szName, SQFUNCTION pfnFunction)
{
	sq_pushroottable(pVM);
	sq_pushstring(pVM, szName, -1);
	sq_newclosure(pVM, pfnFunction, 0);
	sq_createslot(pVM, -3);
	sq_pop(pVM, 1);
}
