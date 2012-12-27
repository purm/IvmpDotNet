#include "SDK\SDK.h"

EXPORT EntityId Pickups_Create(int modelhash, unsigned char type, unsigned int value, CVector3 vecPosition, CVector3 vecRotation) {
	return IVMP::Pickups()->Create(modelhash, type, value, vecPosition, vecRotation);
}

EXPORT bool Pickups_Delete(EntityId pickupid) {
	return IVMP::Pickups()->Delete(pickupid);
}

EXPORT int Pickups_GetModel(EntityId pickupid) {
	return IVMP::Pickups()->GetModel(pickupid);
}

EXPORT int Pickups_GetType(EntityId pickupid) {
	return IVMP::Pickups()->GetType(pickupid);
}

EXPORT bool Pickups_SetValue(EntityId pickupid, unsigned int pvalue) {
	return IVMP::Pickups()->SetValue(pickupid, pvalue);
}

EXPORT unsigned int Pickups_GetValue(EntityId pickupid) {
	return IVMP::Pickups()->GetValue(pickupid);
}

EXPORT bool Pickups_SetCoordinates(EntityId pickupid, CVector3 vecPosition) {
	return IVMP::Pickups()->SetCoordinates(pickupid, vecPosition);
}

EXPORT CVector3 Pickups_GetCoordinates(EntityId pickupid) {
	return IVMP::Pickups()->GetCoordinates(pickupid);
}

EXPORT bool Pickups_SetRotation(EntityId pickupid, CVector3 vecPosition) {
	return IVMP::Pickups()->SetRotation(pickupid, vecPosition);
}

EXPORT CVector3 Pickups_GetRotation(EntityId pickupid) {
	return IVMP::Pickups()->GetRotation(pickupid);
}