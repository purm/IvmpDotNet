#include "SDK\SDK.h"

EXPORT int Vehicles_Create(int iModelId, CVector3 vecPosition, CVector3 vecRotation, int color1, int color2, int color3, int color4, int respawn_delay) {
	return IVMP::Vehicles()->Create(iModelId, vecPosition, vecRotation, color1, color2, color3, color4, respawn_delay);
}

EXPORT bool Vehicles_Delete(EntityId vehicleid) {
	return IVMP::Vehicles()->Delete(vehicleid);
}

EXPORT bool Vehicles_SetCoordinates(EntityId vehicleid, CVector3 vecPosition) {
	return IVMP::Vehicles()->SetCoordinates(vehicleid, vecPosition);
}

EXPORT CVector3 Vehicles_GetCoordinates(EntityId vehicleid) {
	return IVMP::Vehicles()->GetCoordinates(vehicleid);
}

EXPORT bool Vehicles_SetRotation(EntityId vehicleId, CVector3 vecRotation) {
	return IVMP::Vehicles()->SetRotation(vehicleId, vecRotation);
}

EXPORT bool Vehicles_SetDirtLevel(EntityId vehicleid, float fLevel) {
	return IVMP::Vehicles()->SetDirtLevel(vehicleid, fLevel);
}

EXPORT float Vehicles_GetDirtLevel(EntityId vehicleId) {
	return IVMP::Vehicles()->GetDirtLevel(vehicleId);
}

EXPORT bool Vehicles_SetSirenState(EntityId vehicleId, bool sqbState) {
	return IVMP::Vehicles()->SetSirenState(vehicleId, sqbState);
}

EXPORT bool Vehicles_GetSirenState(EntityId vehicleId) {
	return IVMP::Vehicles()->GetSirenState(vehicleId);
}

EXPORT bool Vehicles_SoundHorn(EntityId vehicleId, int iDuration) {
	return IVMP::Vehicles()->SoundHorn(vehicleId, iDuration);
}

EXPORT CVector3 Vehicles_GetRotation(EntityId vehicleId) {
	return IVMP::Vehicles()->GetRotation(vehicleId);
}

EXPORT bool Vehicles_IsValid(EntityId vehicleid) {
	return IVMP::Vehicles()->IsValid(vehicleid);
}

EXPORT bool Vehicles_SetColor(EntityId vehicleid, int * colors) {
	return IVMP::Vehicles()->SetColor(vehicleid, colors);
}

EXPORT BYTE * Vehicles_GetColor(EntityId vehicleid) {
	return IVMP::Vehicles()->GetColor(vehicleid);
}

EXPORT int Vehicles_GetModel(EntityId vehicleid) {
	return IVMP::Vehicles()->GetModel(vehicleid);
}

EXPORT bool Vehicles_SetHealth(EntityId vehicleid, int health) {
	return IVMP::Vehicles()->SetHealth(vehicleid, health);
}

EXPORT int Vehicles_GetHealth(EntityId vehicleid) {
	return IVMP::Vehicles()->GetHealth(vehicleid);
}

EXPORT bool Vehicles_SetVelocity(EntityId vehicleid, CVector3 vecMoveSpeed) {
	return IVMP::Vehicles()->SetVelocity(vehicleid, vecMoveSpeed);
}

EXPORT CVector3 Vehicles_GetVelocity(EntityId vehicleid) {
	return IVMP::Vehicles()->GetVelocity(vehicleid);
}

EXPORT bool Vehicles_SetAngularVelocity(EntityId vehicleid, CVector3 vecTurnSpeed) {
	return IVMP::Vehicles()->SetAngularVelocity(vehicleid, vecTurnSpeed);
}

EXPORT CVector3 Vehicles_GetAngularVelocity(EntityId vehicleid) {
	return IVMP::Vehicles()->GetAngularVelocity(vehicleid);
}

EXPORT bool Vehicles_Respawn(EntityId vehicleId) {
	return IVMP::Vehicles()->Respawn(vehicleId);
}

EXPORT bool Vehicles_IsOccupied(EntityId vehicleId) {
	return IVMP::Vehicles()->IsOccupied(vehicleId);
}

EXPORT int * Vehicles_GetOccupants(EntityId vehicleId) {
	return IVMP::Vehicles()->GetOccupants(vehicleId);
}

EXPORT bool Vehicles_SetLocked(EntityId vehicleId, int iLocked) {
	return IVMP::Vehicles()->SetLocked(vehicleId, iLocked);
}

EXPORT int Vehicles_GetLocked(EntityId vehicleId) {
	return IVMP::Vehicles()->GetLocked(vehicleId);
}

EXPORT bool Vehicles_SetIndicators(EntityId vehicleId, bool bFrontLeft, bool bFrontRight, bool bBackLeft, bool bBackRight) {
	return IVMP::Vehicles()->SetIndicators(vehicleId, bFrontLeft, bFrontRight, bBackLeft, bBackRight);
}

EXPORT int * Vehicles_GetIndicators(EntityId vehicleId) {
	return IVMP::Vehicles()->GetIndicators(vehicleId);
}

EXPORT bool Vehicles_SetComponent(EntityId vehicleId, int iSlot, bool bOn) {
	return IVMP::Vehicles()->SetComponent(vehicleId, iSlot, bOn);
}

EXPORT bool Vehicles_ResetComponents(EntityId vehicleId) {
	return IVMP::Vehicles()->ResetComponents(vehicleId);
}

EXPORT int * Vehicles_GetComponents(EntityId vehicleId) {
	return IVMP::Vehicles()->GetComponents(vehicleId);
}

EXPORT bool Vehicles_SetVariation(EntityId vehicleId, int iVariation) {
	return IVMP::Vehicles()->SetVariation(vehicleId, iVariation);
}

EXPORT int Vehicles_GetVariation(EntityId vehicleId) {
	return IVMP::Vehicles()->GetVariation(vehicleId);
}

EXPORT bool Vehicles_SetEngineStatus(EntityId vehicleId, bool bEngineStatusx) {
	return IVMP::Vehicles()->SetEngineStatus(vehicleId, bEngineStatusx);
}

EXPORT bool Vehicles_GetEngineStatus(EntityId vehicleId) {
	return IVMP::Vehicles()->GetEngineStatus(vehicleId);
}

EXPORT bool Vehicles_SwitchTaxiLights(EntityId vehicleId, bool check) {
	return IVMP::Vehicles()->SwitchTaxiLights(vehicleId, check);
}

EXPORT bool Vehicles_ControlCarDoors(EntityId vehicleId, int door, bool door2, float door3) {
	return IVMP::Vehicles()->ControlCarDoors(vehicleId, door, door2, door3);
}

EXPORT bool Vehicles_SetLights(EntityId vehicleId, bool bLights) {
	return IVMP::Vehicles()->SetLights(vehicleId, bLights);
}

EXPORT bool Vehicles_GetLights(EntityId vehicleId) {
	return IVMP::Vehicles()->GetLights(vehicleId);
}

EXPORT bool Vehicles_GetTaxiLights(EntityId vehicleId) {
	return IVMP::Vehicles()->GetTaxiLights(vehicleId);
}

EXPORT bool Vehicles_RepairWheels(EntityId vehicleId) {
	return IVMP::Vehicles()->RepairWheels(vehicleId);
}

EXPORT bool Vehicles_RepairWindows(EntityId vehicleId) {
	return IVMP::Vehicles()->RepairWindows(vehicleId);
}

EXPORT bool Vehicles_Repair(EntityId vehicleId) {
	return IVMP::Vehicles()->Repair(vehicleId);
}

EXPORT bool Vehicles_SetDimension(EntityId vehicleId, int dimension) {
	return IVMP::Vehicles()->SetDimension(vehicleId, dimension);
}

EXPORT int Vehicles_GetDimension(EntityId vehicleId) {
	return IVMP::Vehicles()->GetDimension(vehicleId);
}

EXPORT bool Vehicles_SetRespawnDelay(EntityId vehicleId, int respawn_delay) {
	return IVMP::Vehicles()->SetRespawnDelay(vehicleId, respawn_delay);
}

EXPORT int Vehicles_GetRespawnDelay(EntityId vehicleId) {
	return IVMP::Vehicles()->GetRespawnDelay(vehicleId);
}