#include "SDK\SDK.h"

EXPORT EntityId Blips_Create(int iSprite, CVector3 vecPosition, bool bShow) {
	return IVMP::Blips()->Create(iSprite, vecPosition, bShow);
}

EXPORT bool Blips_Delete(EntityId blipId) {
	return IVMP::Blips()->Delete(blipId);
}

EXPORT bool Blips_SetCoordinates(EntityId blipId, CVector3 vecPosition) {
	return IVMP::Blips()->SetCoordinates(blipId, vecPosition);
}

EXPORT CVector3 Blips_GetCoordinates(EntityId blipId) {
	return IVMP::Blips()->GetCoordinates(blipId);
}

EXPORT bool Blips_SetColor(EntityId blipId, int iColor, EntityId playerId) {
	return IVMP::Blips()->SetColor(blipId, iColor, playerId);
}

EXPORT int Blips_GetColor(EntityId blipId) {
	return IVMP::Blips()->GetColor(blipId);
}

EXPORT bool Blips_SetSize(EntityId blipId, float fSize, EntityId playerId) {
	return IVMP::Blips()->SetSize(blipId, fSize, playerId);
}

EXPORT float Blips_GetSize(EntityId blipId) {
	return IVMP::Blips()->GetSize(blipId);
}

EXPORT bool Blips_ToggleShortRange(EntityId blipId, bool bToggle, EntityId playerId) {
	return IVMP::Blips()->ToggleShortRange(blipId, bToggle, playerId);
}

EXPORT bool Blips_ToggleRoute(EntityId blipId, bool bToggle, EntityId playerId) {
	return IVMP::Blips()->ToggleRoute(blipId, bToggle, playerId);
}

EXPORT bool Blips_SetName(EntityId blipId, const char * szName, EntityId playerId) {
	return IVMP::Blips()->SetName(blipId, szName, playerId);
}

EXPORT const char * Blips_GetName(EntityId blipId) {
	return IVMP::Blips()->GetName(blipId);
}

EXPORT bool Blips_CreatePlayerBlip(EntityId playerId, int iSprite) {
	return IVMP::Blips()->CreatePlayerBlip(playerId, iSprite);
}

EXPORT bool Blips_DeletePlayerBlip(EntityId playerId) {
	return IVMP::Blips()->DeletePlayerBlip(playerId);
}

EXPORT bool Blips_TogglePlayerBlipDisplay(EntityId playerId, bool bToggle) {
	return IVMP::Blips()->TogglePlayerBlipDisplay(playerId, bToggle);
}

EXPORT bool Blips_TogglePlayerShortRange(EntityId playerId, bool bToggle) {
	return IVMP::Blips()->TogglePlayerShortRange(playerId, bToggle);
}

