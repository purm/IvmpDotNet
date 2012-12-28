#include "SDK\SDK.h"

EXPORT EntityId Checkpoints_Create(int iType, CVector3 vecPosition, CVector3 vecTargetPosition, float fRadius) {
	return IVMP::Checkpoints()->Create(iType, vecPosition, vecTargetPosition, fRadius);
}

EXPORT bool Checkpoints_Delete(EntityId checkpointId) {
	return IVMP::Checkpoints()->Delete(checkpointId);
}

EXPORT bool Checkpoints_ShowForPlayer(EntityId checkpointId, EntityId playerId) {
	return IVMP::Checkpoints()->ShowForPlayer(checkpointId, playerId);
}

EXPORT bool Checkpoints_HideForPlayer(EntityId checkpointId, EntityId playerId) {
	return IVMP::Checkpoints()->HideForPlayer(checkpointId, playerId);
}

EXPORT bool Checkpoints_ShowForAll(EntityId checkpointId) {
	return IVMP::Checkpoints()->ShowForAll(checkpointId);
}

EXPORT bool Checkpoints_HideForAll(EntityId checkpointId) {
	return IVMP::Checkpoints()->HideForAll(checkpointId);
}

EXPORT bool Checkpoints_SetType(EntityId checkpointId, int iType) {
	return IVMP::Checkpoints()->SetType(checkpointId, iType);
}

EXPORT int Checkpoints_GetType(EntityId checkpointId) {
	return IVMP::Checkpoints()->GetType(checkpointId);
}

EXPORT bool Checkpoints_SetPosition(EntityId checkpointId, CVector3 vecPosition) {
	return IVMP::Checkpoints()->SetPosition(checkpointId, vecPosition);
}

EXPORT CVector3 Checkpoints_GetPosition(EntityId checkpointId) {
	return IVMP::Checkpoints()->GetPosition(checkpointId);
}

EXPORT bool Checkpoints_SetTargetPosition(EntityId checkpointId, CVector3 vecTargetPosition) {
	return IVMP::Checkpoints()->SetTargetPosition(checkpointId, vecTargetPosition);
}

EXPORT CVector3 Checkpoints_GetTargetPosition(EntityId checkpointId) {
	return IVMP::Checkpoints()->GetTargetPosition(checkpointId);
}

EXPORT bool Checkpoints_SetRadius(EntityId checkpointId, float fRadius) {
	return IVMP::Checkpoints()->SetRadius(checkpointId, fRadius);
}

EXPORT float Checkpoints_GetRadius(EntityId checkpointId) {
	return IVMP::Checkpoints()->GetRadius(checkpointId);
}

EXPORT bool Checkpoints_SetDimension(EntityId checkpointId, unsigned char ucDimension) {
	return IVMP::Checkpoints()->SetDimension(checkpointId, ucDimension);
}

EXPORT int Checkpoints_GetDimension(EntityId checkpointId) {
	return IVMP::Checkpoints()->GetDimension(checkpointId);
}

