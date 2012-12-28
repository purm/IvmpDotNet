#include "SDK\SDK.h"

EXPORT const char * Scripts_GetScriptName(void * pVM) {
	return IVMP::Scripts()->GetScriptName(pVM);
}

EXPORT bool Scripts_LoadScript(const char * szScript) {
	return IVMP::Scripts()->LoadScript(szScript);
}

EXPORT bool Scripts_UnloadScript(const char * szScript) {
	return IVMP::Scripts()->UnloadScript(szScript);
}

EXPORT bool Scripts_ReloadScript(const char * szScript) {
	return IVMP::Scripts()->ReloadScript(szScript);
}

EXPORT bool Scripts_LoadClientScript(const char * szScript) {
	return IVMP::Scripts()->LoadClientScript(szScript);
}

EXPORT bool Scripts_UnloadClientScript(const char * szScript) {
	return IVMP::Scripts()->UnloadClientScript(szScript);
}

EXPORT bool Scripts_ReloadClientScript(const char * szScript) {
	return IVMP::Scripts()->ReloadClientScript(szScript);
}

EXPORT bool Scripts_LoadClientResource(const char * szResource) {
	return IVMP::Scripts()->LoadClientResource(szResource);
}

EXPORT bool Scripts_UnloadClientResource(const char * szResource) {
	return IVMP::Scripts()->UnloadClientResource(szResource);
}

EXPORT bool Scripts_ReloadClientResource(const char * szResource) {
	return IVMP::Scripts()->ReloadClientResource(szResource);
}

