using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace IvmpDotNet.Imports {
    public static class Area {
        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Single Area_Points2D(Single x, Single y, Single xx, Single yy);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Single Area_Points3D(CVector3 vec1, CVector3 vec2);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Area_PointInCircle(Single x, Single y, Single xx, Single yy, Single distance);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Area_PointInTube(Single tubeX, Single tubeY, Single tubeZ, Single tubeHeight, Single tubeRadius, CVector3 vec);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Area_PointInBall(CVector3 vec1, CVector3 vec2, Single distance);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Area_PointInArea(Single areax, Single areay, Single areaxx, Single areayy, Single pointx, Single pointy);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Area_PointInCuboid(CVector3 area1, CVector3 area2, CVector3 point);
    }
}