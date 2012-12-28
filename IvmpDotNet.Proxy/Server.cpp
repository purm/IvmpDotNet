#include "SDK\SDK.h"

EXPORT void Server_Log(const char * text) {
	IVMP::Server()->Log(text);
}

EXPORT void Server_LogF(const char * text) {
	IVMP::Server()->LogF(text);
}

EXPORT void Server_AddRule(const char * rule, const char * value) {
	IVMP::Server()->AddRule(rule, value);
}

EXPORT void Server_RemoveRule(const char * rule) {
	IVMP::Server()->RemoveRule(rule);
}

EXPORT void Server_SetRule(const char * rule, const char * value) {
	IVMP::Server()->SetRule(rule, value);
}

EXPORT const char * Server_GetRule(const char * rule) {
	return IVMP::Server()->GetRule(rule);
}

EXPORT void Server_SetPassword(const char * pass) {
	IVMP::Server()->SetPassword(pass);
}

EXPORT void Server_SetHostName(const char * szHostname) {
	IVMP::Server()->SetHostName(szHostname);
}

EXPORT void Server_TogglePayAndSpray(bool toggle) {
	IVMP::Server()->TogglePayAndSpray(toggle);
}

EXPORT void Server_ToggleAutoAim(bool toggle) {
	IVMP::Server()->ToggleAutoAim(toggle);
}

EXPORT void Server_SendInput(const char * input) {
	IVMP::Server()->SendInput(input);
}

EXPORT const char * Server_GetWeaponName(int iWeaponId) {
	return IVMP::Server()->GetWeaponName(iWeaponId);
}

EXPORT const char * Server_GetVehicleName(int iModelId) {
	return IVMP::Server()->GetVehicleName(iModelId);
}

EXPORT void Server_ToggleFrequentEvents(bool bToggle) {
	IVMP::Server()->ToggleFrequentEvents(bToggle);
}

EXPORT bool Server_SetWeather(int iWeather) {
	return IVMP::Server()->SetWeather(iWeather);
}

EXPORT bool Server_ForceWind(float fWind) {
	return IVMP::Server()->ForceWind(fWind);
}