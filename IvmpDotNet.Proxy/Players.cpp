#include "SDK\SDK.h"

EXPORT bool Players_IsConnected(EntityId playerId) {
	return IVMP::Players()->IsConnected(playerId);
}

EXPORT const char * Players_GetName(EntityId playerId) {
	return IVMP::Players()->GetName(playerId);
}

EXPORT bool Players_SetName(EntityId playerId, const char * szName) {
	return IVMP::Players()->SetName(playerId, szName);
}

EXPORT bool Players_GiveWeapon(EntityId playerId, int iWeaponId, int iAmmo) {
	return IVMP::Players()->GiveWeapon(playerId, iWeaponId, iAmmo);
}

EXPORT bool Players_RemoveWeapons(EntityId playerId) {
	return IVMP::Players()->RemoveWeapons(playerId);
}

EXPORT bool Players_SetWantedLevel(EntityId playerId, int iWantedLevel) {
	return IVMP::Players()->SetWantedLevel(playerId, iWantedLevel);
}

EXPORT bool Players_SetHealth(EntityId playerId, int iHealth) {
	return IVMP::Players()->SetHealth(playerId, iHealth);
}

EXPORT int Players_GetHealth(EntityId playerId) {
	return IVMP::Players()->GetHealth(playerId);
}

EXPORT bool Players_SetArmour(EntityId playerId, int iArmour) {
	return IVMP::Players()->SetArmour(playerId, iArmour);
}

EXPORT int Players_GetArmour(EntityId playerId) {
	return IVMP::Players()->GetArmour(playerId);
}

EXPORT bool Players_SetCoordinates(EntityId playerId, CVector3 vecPos) {
	return IVMP::Players()->SetCoordinates(playerId, vecPos);
}

EXPORT CVector3 Players_GetCoordinates(EntityId playerId) {
	return IVMP::Players()->GetCoordinates(playerId);
}

EXPORT bool Players_SetTime(EntityId playerId, unsigned char iHour, unsigned char iMinute) {
	return IVMP::Players()->SetTime(playerId, iHour, iMinute);
}

EXPORT bool Players_SetWeather(EntityId playerId, unsigned char iWeather) {
	return IVMP::Players()->SetWeather(playerId, iWeather);
}

EXPORT bool Players_SetGravity(EntityId playerId, float fGravity) {
	return IVMP::Players()->SetGravity(playerId, fGravity);
}

EXPORT bool Players_SendMessage(EntityId playerId, const char * szMessage, int iColor, bool sqbAllowFormatting) {
	return IVMP::Players()->SendMessage(playerId, szMessage, iColor, sqbAllowFormatting);
}

EXPORT bool Players_SendMessageToAll(const char * szMessage, int iColor, bool sqbAllowFormatting) {
	return IVMP::Players()->SendMessageToAll(szMessage, iColor, sqbAllowFormatting);
}

EXPORT bool Players_IsInAnyVehicle(EntityId playerId) {
	return IVMP::Players()->IsInAnyVehicle(playerId);
}

EXPORT bool Players_IsInVehicle(EntityId playerId, EntityId vehicleId) {
	return IVMP::Players()->IsInVehicle(playerId, vehicleId);
}

EXPORT EntityId Players_GetVehicleId(EntityId playerId) {
	return IVMP::Players()->GetVehicleId(playerId);
}

EXPORT int Players_GetSeatId(EntityId playerId) {
	return IVMP::Players()->GetSeatId(playerId);
}

EXPORT bool Players_IsOnFoot(EntityId playerId) {
	return IVMP::Players()->IsOnFoot(playerId);
}

EXPORT bool Players_TogglePayAndSpray(EntityId playerId, bool sqbToggle) {
	return IVMP::Players()->TogglePayAndSpray(playerId, sqbToggle);
}

EXPORT bool Players_ToggleAutoAim(EntityId playerId, bool sqbToggle) {
	return IVMP::Players()->ToggleAutoAim(playerId, sqbToggle);
}

EXPORT bool Players_SetSpawnLocation(EntityId playerId, CVector3 vecPos, float fRotation) {
	return IVMP::Players()->SetSpawnLocation(playerId, vecPos, fRotation);
}

EXPORT bool Players_SetModel(EntityId playerId, int iModelId) {
	return IVMP::Players()->SetModel(playerId, iModelId);
}

EXPORT int Players_GetModel(EntityId playerId) {
	return IVMP::Players()->GetModel(playerId);
}

EXPORT bool Players_ToggleControls(EntityId playerId, bool sqbControls) {
	return IVMP::Players()->ToggleControls(playerId, sqbControls);
}

EXPORT bool Players_IsSpawned(EntityId playerId) {
	return IVMP::Players()->IsSpawned(playerId);
}

EXPORT bool Players_SetHeading(EntityId playerId, float fHeading) {
	return IVMP::Players()->SetHeading(playerId, fHeading);
}

EXPORT float Players_GetHeading(EntityId playerId) {
	return IVMP::Players()->GetHeading(playerId);
}

EXPORT bool Players_TogglePhysics(EntityId playerId, bool sqbToggle) {
	return IVMP::Players()->TogglePhysics(playerId, sqbToggle);
}

EXPORT bool Players_Kick(EntityId playerId, bool sqbKickMessage) {
	return IVMP::Players()->Kick(playerId, sqbKickMessage);
}

EXPORT bool Players_Ban(EntityId playerId, unsigned int uiSeconds) {
	return IVMP::Players()->Ban(playerId, uiSeconds);
}

EXPORT const char * Players_GetIp(EntityId playerId) {
	return IVMP::Players()->GetIp(playerId);
}

EXPORT bool Players_GiveMoney(EntityId playerId, int iMoney) {
	return IVMP::Players()->GiveMoney(playerId, iMoney);
}

EXPORT bool Players_SetMoney(EntityId playerId, int iMoney) {
	return IVMP::Players()->SetMoney(playerId, iMoney);
}

EXPORT bool Players_ResetMoney(EntityId playerId) {
	return IVMP::Players()->ResetMoney(playerId);
}

EXPORT int Players_GetMoney(EntityId playerId) {
	return IVMP::Players()->GetMoney(playerId);
}

EXPORT bool Players_ToggleFrozen(EntityId playerId, bool sqbPlayerFrozen, bool sqbCameraFrozen) {
	return IVMP::Players()->ToggleFrozen(playerId, sqbPlayerFrozen, sqbCameraFrozen);
}

EXPORT int Players_GetState(EntityId playerId) {
	return IVMP::Players()->GetState(playerId);
}

EXPORT bool Players_DisplayText(EntityId playerId, float fPosX, float fPosY, const char * szText, int iTime) {
	return IVMP::Players()->DisplayText(playerId, fPosX, fPosY, szText, iTime);
}

EXPORT bool Players_DisplayTextForAll(float fPosX, float fPosY, const char * szText, int iTime) {
	return IVMP::Players()->DisplayTextForAll(fPosX, fPosY, szText, iTime);
}

EXPORT bool Players_DisplayInfoText(EntityId playerId, const char * szText, int iTime) {
	return IVMP::Players()->DisplayInfoText(playerId, szText, iTime);
}

EXPORT bool Players_DisplayInfoTextForAll(const char * szText, int iTime) {
	return IVMP::Players()->DisplayInfoTextForAll(szText, iTime);
}

EXPORT bool Players_SetVelocity(EntityId playerId, CVector3 vecMoveSpeed) {
	return IVMP::Players()->SetVelocity(playerId, vecMoveSpeed);
}

EXPORT CVector3 Players_GetVelocity(EntityId playerId) {
	return IVMP::Players()->GetVelocity(playerId);
}

EXPORT bool Players_WarpIntoVehicle(EntityId playerId, EntityId vehicleId, int iSeatId) {
	return IVMP::Players()->WarpIntoVehicle(playerId, vehicleId, iSeatId);
}

EXPORT bool Players_RemoveFromVehicle(EntityId playerId, bool bGraceful) {
	return IVMP::Players()->RemoveFromVehicle(playerId, bGraceful);
}

EXPORT int Players_GetWeapon(EntityId playerId) {
	return IVMP::Players()->GetWeapon(playerId);
}

EXPORT int Players_GetAmmo(EntityId playerId) {
	return IVMP::Players()->GetAmmo(playerId);
}

EXPORT const char * Players_GetSerial(EntityId playerId) {
	return IVMP::Players()->GetSerial(playerId);
}

EXPORT bool Players_SetCameraBehind(EntityId playerId) {
	return IVMP::Players()->SetCameraBehind(playerId);
}

EXPORT bool Players_SetDucking(EntityId playerId, bool sqbDucking) {
	return IVMP::Players()->SetDucking(playerId, sqbDucking);
}

EXPORT bool Players_IsDucking(EntityId playerId) {
	return IVMP::Players()->IsDucking(playerId);
}

EXPORT bool Players_SetInvincible(EntityId playerId, bool sqbInvincible) {
	return IVMP::Players()->SetInvincible(playerId, sqbInvincible);
}

EXPORT bool Players_ToggleHUD(EntityId playerId, bool sqbToggle) {
	return IVMP::Players()->ToggleHUD(playerId, sqbToggle);
}

EXPORT bool Players_ToggleRadar(EntityId playerId, bool sqbToggle) {
	return IVMP::Players()->ToggleRadar(playerId, sqbToggle);
}

EXPORT bool Players_ToggleNames(EntityId playerId, bool sqbToggle) {
	return IVMP::Players()->ToggleNames(playerId, sqbToggle);
}

EXPORT bool Players_ToggleAreaNames(EntityId playerId, bool sqbToggle) {
	return IVMP::Players()->ToggleAreaNames(playerId, sqbToggle);
}

EXPORT bool Players_SetColor(EntityId playerId, int color) {
	return IVMP::Players()->SetColor(playerId, color);
}

EXPORT int Players_GetColor(EntityId playerId) {
	return IVMP::Players()->GetColor(playerId);
}

EXPORT int Players_GetPing(EntityId playerId) {
	return IVMP::Players()->GetPing(playerId);
}

EXPORT bool Players_SetClothes(EntityId iPlayerId, int iBodyPart, int iClothes) {
	return IVMP::Players()->SetClothes(iPlayerId, iBodyPart, iClothes);
}

EXPORT int * Players_GetClothes(EntityId playerId) {
	return IVMP::Players()->GetClothes(playerId);
}

EXPORT bool Players_ResetClothes(EntityId playerId) {
	return IVMP::Players()->ResetClothes(playerId);
}

EXPORT bool Players_Respawn(EntityId playerId) {
	return IVMP::Players()->Respawn(playerId);
}

EXPORT bool Players_GiveHelmet(EntityId playerId) {
	return IVMP::Players()->GiveHelmet(playerId);
}

EXPORT bool Players_RemoveHelmet(EntityId playerId) {
	return IVMP::Players()->RemoveHelmet(playerId);
}

EXPORT bool Players_ToggleHelmet(EntityId playerId, bool sqbToggle) {
	return IVMP::Players()->ToggleHelmet(playerId, sqbToggle);
}

EXPORT bool Players_SetCameraPos(EntityId playerId, CVector3 vecPos) {
	return IVMP::Players()->SetCameraPos(playerId, vecPos);
}

EXPORT bool Players_SetCameraLookAt(EntityId playerId, CVector3 vecPos) {
	return IVMP::Players()->SetCameraLookAt(playerId, vecPos);
}

EXPORT bool Players_ResetCamera(EntityId playerId) {
	return IVMP::Players()->ResetCamera(playerId);
}

EXPORT CControlState Players_GetPreviousControlState(EntityId playerId) {
	return IVMP::Players()->GetPreviousControlState(playerId);
}

EXPORT CControlState Players_GetControlState(EntityId playerId) {
	return IVMP::Players()->GetControlState(playerId);
}

EXPORT bool Players_TriggerEvent(EntityId playerid, const char * szEventName, const char * szFormat) {
	return IVMP::Players()->TriggerEvent(playerid, szEventName, szFormat);
}

EXPORT bool Players_forceAnim(EntityId playerId, const char * szGroup, const char * szAnim) {
	return IVMP::Players()->forceAnim(playerId, szGroup, szAnim);
}

EXPORT bool Players_requestAnim(EntityId playerId) {
	return IVMP::Players()->requestAnim(playerId);
}

EXPORT bool Players_triggerAudioEvent(EntityId playerId, const char * szAudio) {
	return IVMP::Players()->triggerAudioEvent(playerId, szAudio);
}

EXPORT bool Players_triggerMissionCompleteAudio(EntityId playerId, int iMission) {
	return IVMP::Players()->triggerMissionCompleteAudio(playerId, iMission);
}

EXPORT bool Players_triggerPoliceReport(EntityId playerId, const char * szAudio) {
	return IVMP::Players()->triggerPoliceReport(playerId, szAudio);
}

EXPORT bool Players_fadeScreenIn(EntityId playerId, int iDuration) {
	return IVMP::Players()->fadeScreenIn(playerId, iDuration);
}

EXPORT bool Players_fadeScreenOut(EntityId playerId, int iDuration) {
	return IVMP::Players()->fadeScreenOut(playerId, iDuration);
}

EXPORT bool Players_blockWeaponChange(EntityId playerId, bool btoggle) {
	return IVMP::Players()->blockWeaponChange(playerId, btoggle);
}

EXPORT bool Players_blockWeaponDrop(EntityId playerId, bool btoggle) {
	return IVMP::Players()->blockWeaponDrop(playerId, btoggle);
}

EXPORT bool Players_SetDimension(EntityId playerId, unsigned char ucDimension) {
	return IVMP::Players()->SetDimension(playerId, ucDimension);
}

EXPORT int Players_GetDimension(EntityId playerId) {
	return IVMP::Players()->GetDimension(playerId);
}

