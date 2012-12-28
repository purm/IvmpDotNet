#include "SDK\SDK.h"

EXPORT bool DoesExist(EntityId objectId) {
	return GetObjectManager()->DoesExist(objectId);
}