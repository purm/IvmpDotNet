#include "SDK\SDK.h"

EXPORT bool GetPlayerManager_DoesExist(EntityId playerId) {
	return GetPlayerManager()->DoesExist(playerId);
}

EXPORT void GetPlayerManager_Add(EntityId playerId, char * sPlayerName) {
	GetPlayerManager()->Add(playerId, sPlayerName);
}

EXPORT bool GetPlayerManager_Remove(EntityId playerId, BYTE byteReason) {
	return GetPlayerManager()->Remove(playerId, byteReason);
}

EXPORT bool GetPlayerManager_IsNameInUse(char * szNick) {
	return GetPlayerManager()->IsNameInUse(szNick);
}

EXPORT EntityId GetPlayerManager_GetPlayerFromName(char * sNick) {
	return GetPlayerManager()->GetPlayerFromName(sNick);
}

EXPORT CPlayerInterface * GetPlayerManager_GetAt(EntityId playerId) {
	return GetPlayerManager()->GetAt(playerId);
}