#include "SDK\SDK.h"

EXPORT bool World_SetTime(int iHour, int iMinute) {
	return IVMP::World()->SetTime(iHour, iMinute);
}

EXPORT bool World_SetMinuteDuration(int iMinuteDuration) {
	return IVMP::World()->SetMinuteDuration(iMinuteDuration);
}

EXPORT bool World_SetDayOfWeek(int iDay) {
	return IVMP::World()->SetDayOfWeek(iDay);
}

EXPORT bool World_SetTrafficLightsState(int iState) {
	return IVMP::World()->SetTrafficLightsState(iState);
}

EXPORT bool World_SetTrafficLightsLocked(bool b) {
	return IVMP::World()->SetTrafficLightsLocked(b);
}

EXPORT bool World_SetTrafficLightsPhaseDuration(int iPhase, int iDuration) {
	return IVMP::World()->SetTrafficLightsPhaseDuration(iPhase, iDuration);
}