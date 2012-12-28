#include "SDK\SDK.h"

EXPORT EntityId Actors_Create(int iModelId, CVector3 vecPosition, float fHeading) {
	return IVMP::Actors()->Create(iModelId, vecPosition, fHeading);
}

EXPORT bool Actors_Delete(EntityId actorId) {
	return IVMP::Actors()->Delete(actorId);
}

EXPORT bool Actors_IsValid(EntityId actorId) {
	return IVMP::Actors()->IsValid(actorId);
}

EXPORT bool Actors_SetCoordinates(EntityId actorId, CVector3 vecPosition) {
	return IVMP::Actors()->SetCoordinates(actorId, vecPosition);
}

EXPORT bool Actors_SetHeading(EntityId actorId, float fHeading) {
	return IVMP::Actors()->SetHeading(actorId, fHeading);
}

EXPORT bool Actors_WalkToCoordinates(EntityId playerId, EntityId actorId, CVector3 vecPosition, int iType) {
	return IVMP::Actors()->WalkToCoordinates(playerId, actorId, vecPosition, iType);
}

EXPORT CVector3 Actors_GetCoordinates(EntityId actorId) {
	return IVMP::Actors()->GetCoordinates(actorId);
}

EXPORT float Actors_GetHeading(EntityId actorId) {
	return IVMP::Actors()->GetHeading(actorId);
}

EXPORT int Actors_GetModel(EntityId actorId) {
	return IVMP::Actors()->GetModel(actorId);
}

EXPORT bool Actors_SetName(EntityId actorId, const char * szName) {
	return IVMP::Actors()->SetName(actorId, szName);
}

EXPORT const char * Actors_GetName(EntityId actorId) {
	return IVMP::Actors()->GetName(actorId);
}

EXPORT bool Actors_ToggleNametag(EntityId actorId, bool bShow) {
	return IVMP::Actors()->ToggleNametag(actorId, bShow);
}

EXPORT bool Actors_ToggleBlip(EntityId actorId, bool bShow) {
	return IVMP::Actors()->ToggleBlip(actorId, bShow);
}

EXPORT bool Actors_SetColor(EntityId actorId, int color) {
	return IVMP::Actors()->SetColor(actorId, color);
}

EXPORT int Actors_GetColor(EntityId actorId) {
	return IVMP::Actors()->GetColor(actorId);
}

EXPORT bool Actors_ToggleFrozen(EntityId actorId, bool frozen) {
	return IVMP::Actors()->ToggleFrozen(actorId, frozen);
}

EXPORT bool Actors_ToggleHelmet(EntityId actorId, bool helmet) {
	return IVMP::Actors()->ToggleHelmet(actorId, helmet);
}

EXPORT bool Actors_WarpIntoVehicle(EntityId actorId, int vehicleid, int seatid) {
	return IVMP::Actors()->WarpIntoVehicle(actorId, vehicleid, seatid);
}

EXPORT bool Actors_RemoveFromVehicle(EntityId actorId) {
	return IVMP::Actors()->RemoveFromVehicle(actorId);
}

EXPORT bool Actors_DriveToCoordinates(EntityId actorId, CVector3 vecDriveTo, CVector3 vecDriveRot, bool bStop) {
	return IVMP::Actors()->DriveToCoordinates(actorId, vecDriveTo, vecDriveRot, bStop);
}

EXPORT bool Actors_ForceAnim(EntityId actorId, const char * szGroup, const char * szAnim) {
	return IVMP::Actors()->ForceAnim(actorId, szGroup, szAnim);
}

