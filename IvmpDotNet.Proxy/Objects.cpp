#include "SDK\SDK.h"

EXPORT EntityId Objects_Create(int modelhash, CVector3 vecPosition, CVector3 vecRotation) {
	return IVMP::Objects()->Create(modelhash, vecPosition, vecRotation);
}

EXPORT bool Objects_Delete(EntityId objectId) {
	return IVMP::Objects()->Delete(objectId);
}

EXPORT int Objects_GetModel(EntityId objectId) {
	return IVMP::Objects()->GetModel(objectId);
}

EXPORT bool Objects_SetCoordinates(EntityId objectId, CVector3 vecPosition) {
	return IVMP::Objects()->SetCoordinates(objectId, vecPosition);
}

EXPORT CVector3 Objects_GetCoordinates(EntityId objectId) {
	return IVMP::Objects()->GetCoordinates(objectId);
}

EXPORT bool Objects_SetRotation(EntityId objectId, CVector3 vecRotation) {
	return IVMP::Objects()->SetRotation(objectId, vecRotation);
}

EXPORT CVector3 Objects_GetRotation(EntityId objectId) {
	return IVMP::Objects()->GetRotation(objectId);
}

EXPORT void Objects_CreateExplosion(CVector3 vecPos, float fDensity) {
	IVMP::Objects()->CreateExplosion(vecPos, fDensity);
}

EXPORT EntityId Objects_CreateFire(CVector3 vecPos, float fDensity) {
	return IVMP::Objects()->CreateFire(vecPos, fDensity);
}

EXPORT void Objects_DeleteFire(EntityId fireId) {
	IVMP::Objects()->DeleteFire(fireId);
}

EXPORT bool Objects_AttachPed(EntityId objectId, EntityId playerId, CVector3 vecPos, CVector3 vecRot) {
	return IVMP::Objects()->AttachPed(objectId, playerId, vecPos, vecRot);
}

EXPORT bool Objects_AttachVehicle(EntityId objectId, EntityId vehicleId, CVector3 vecPos, CVector3 vecRot) {
	return IVMP::Objects()->AttachVehicle(objectId, vehicleId, vecPos, vecRot);
}

EXPORT bool Objects_Move(EntityId objectId, CVector3 vecMoveTarget, CVector3 vecMoveRot, float fSpeed) {
	return IVMP::Objects()->Move(objectId, vecMoveTarget, vecMoveRot, fSpeed);
}

EXPORT bool Objects_Rotate(EntityId objectId, CVector3 vecRotation, float fSpeed) {
	return IVMP::Objects()->Rotate(objectId, vecRotation, fSpeed);
}

EXPORT bool Objects_AttachToPlayer(EntityId objectId, EntityId playerId, CVector3 vecPos, CVector3 vecRot, int iBone) {
	return IVMP::Objects()->AttachToPlayer(objectId, playerId, vecPos, vecRot, iBone);
}

EXPORT bool Objects_SetDimension(EntityId objectId, unsigned char ucDimension) {
	return IVMP::Objects()->SetDimension(objectId, ucDimension);
}

EXPORT unsigned char Objects_GetDimension(EntityId objectId) {
	return IVMP::Objects()->GetDimension(objectId);
}