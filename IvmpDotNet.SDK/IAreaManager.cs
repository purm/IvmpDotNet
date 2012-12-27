using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    public interface IAreaManager {
        Single Points2D(Single x, Single y, Single xx, Single yy);
        Single Points3D(CVector3 vec1, CVector3 vec2);
        bool PointInCircle(Single x, Single y, Single xx, Single yy, Single distance);
        bool PointInTube(Single tubeX, Single tubeY, Single tubeZ, Single tubeHeight, Single tubeRadius, CVector3 vec);
        bool PointInBall(CVector3 vec1, CVector3 vec2, Single distance);
        bool PointInArea(Single areax, Single areay, Single areaxx, Single areayy, Single pointx, Single pointy);
        bool PointInCuboid(CVector3 area1, CVector3 area2, CVector3 point);
    }
}
