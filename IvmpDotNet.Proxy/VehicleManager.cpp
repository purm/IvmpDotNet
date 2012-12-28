#include "SDK\SDK.h"

EXPORT EntityId GetVehicleManager_Add(int iModelId, CVector3 vecSpawnPosition, CVector3 vecSpawnRotation, BYTE byteColor1, BYTE byteColor2, BYTE byteColor3, BYTE byteColor4, int respawn_delay = 1) {
	return GetVehicleManager()->Add(iModelId, vecSpawnPosition, vecSpawnRotation, byteColor1, byteColor2, byteColor3, byteColor4, 1);
}

EXPORT void GetVehicleManager_Remove(EntityId vehicleId) {
	GetVehicleManager()->Remove(vehicleId);
}

EXPORT bool GetVehicleManager_DoesExist(EntityId vehicleId) {
	return GetVehicleManager()->DoesExist(vehicleId);
}

EXPORT CVehicleInterface * GetVehicleManager_GetAt(EntityId vehicleId) {
	return GetVehicleManager()->GetAt(vehicleId);
}