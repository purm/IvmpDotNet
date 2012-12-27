#include "SDK\SDK.h"

EXPORT float Area_Points2D(float x, float y, float xx, float yy) {
	return IVMP::Area()->Points2D(x, y, xx, yy);
}

EXPORT float Area_Points3D(CVector3 vec1, CVector3 vec2) {
	return IVMP::Area()->Points3D(vec1, vec2);
}

EXPORT bool Area_PointInCircle(float x, float y, float xx, float yy, float distance) {
	return IVMP::Area()->PointInCircle(x, y, xx, yy, distance);
}

EXPORT bool Area_PointInTube(float tubeX, float tubeY, float tubeZ, float tubeHeight, float tubeRadius, CVector3 vec) {
	return IVMP::Area()->PointInTube(tubeX, tubeY, tubeZ, tubeHeight, tubeRadius, vec);
}

EXPORT bool Area_PointInBall(CVector3 vec1, CVector3 vec2, float distance) {
	return IVMP::Area()->PointInBall(vec1, vec2, distance);
}

EXPORT bool Area_PointInArea(float areax, float areay, float areaxx, float areayy, float pointx, float pointy) {
	return IVMP::Area()->PointInArea(areax, areay, areaxx, areayy, pointx, pointy);
}

EXPORT bool Area_PointInCuboid(CVector3 area1, CVector3 area2, CVector3 point) {
	return IVMP::Area()->PointInCuboid(area1, area2, point);
}

