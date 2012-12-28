using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvmpDotNet.Imports;

namespace IvmpDotNet.Wrappings {
    public class AreaManager : IAreaManager {
        public float DistanceBetween2d(float x, float y, float xx, float yy) {
            return Area.Area_Points2D(x, y, xx, yy);
        }

        public float DistanceBetween3d(CVector3 vec1, CVector3 vec2) {
            return Area.Area_Points3D(vec1, vec2);
        }

        public bool IsPointInCircle(float x, float y, float xx, float yy, float distance) {
            return Area.Area_PointInCircle(x, y, xx, yy, distance);
        }

        public bool IsPointInBall(CVector3 vec1, CVector3 vec2, float distance) {
            return Area.Area_PointInBall(vec1, vec2, distance);
        }

        public bool IsPointInArea(float areax, float areay, float areaxx, float areayy, float pointx, float pointy) {
            return Area.Area_PointInArea(areax, areay, areaxx, areayy, pointx, pointy);
        }

        public bool IsPointInCuboid(CVector3 area1, CVector3 area2, CVector3 point) {
            return Area.Area_PointInCuboid(area1, area2, point);
        }

        public bool IsPointInTube(CVector3 tubeCoords, float tubeHeight, float tubeRadius, CVector3 point) {
            return Area.Area_PointInTube(tubeCoords.X, tubeCoords.Y, tubeCoords.Z, tubeHeight, tubeRadius, point);
        }
    }
}
