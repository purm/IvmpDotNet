#include "SDK\SDK.h"

EXPORT const char * Hash_md5(const char * toHash) {
	return IVMP::Hash()->md5(toHash);
}

EXPORT const char * Hash_md5File(const char * szFileName) {
	return IVMP::Hash()->md5File(szFileName);
}

