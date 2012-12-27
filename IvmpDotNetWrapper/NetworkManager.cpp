#include "SDK\SDK.h"

EXPORT bool NetworkManager_AddBan(const char* strIp, unsigned int uiSeconds) {
	return GetNetworkManager()->AddBan(strIp, uiSeconds);
}