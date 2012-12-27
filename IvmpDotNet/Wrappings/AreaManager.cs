using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvmpDotNet.Imports;

namespace IvmpDotNet.Wrappings {
    public class AreaManager : IAreaManager {
        public float Points2D(float x, float y, float xx, float yy) {
            return Area.Area_Points2D(x, y, xx, yy);
        }

        public float Points3D(CVector3 vec1, CVector3 vec2) {
            return Area.Area_Points3D(vec1, vec2);
        }

        public bool PointInCircle(float x, float y, float xx, float yy, float distance) {
            return Area.Area_PointInCircle(x, y, xx, yy, distance);
        }

        public bool PointInTube(float tubeX, float tubeY, float tubeZ, float tubeHeight, float tubeRadius, CVector3 vec) {
            return Area.Area_PointInTube(tubeX, tubeY, tubeZ, tubeHeight, tubeRadius, vec);
        }

        public bool PointInBall(CVector3 vec1, CVector3 vec2, float distance) {
            return Area.Area_PointInBall(vec1, vec2, distance);
        }

        public bool PointInArea(float areax, float areay, float areaxx, float areayy, float pointx, float pointy) {
            return Area.Area_PointInArea(areax, areay, areaxx, areayy, pointx, pointy);
        }

        public bool PointInCuboid(CVector3 area1, CVector3 area2, CVector3 point) {
            return Area.Area_PointInCuboid(area1, area2, point);
        }
    }
}
