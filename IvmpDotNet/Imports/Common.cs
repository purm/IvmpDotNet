using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace IvmpDotNet.Imports {
    [StructLayout(LayoutKind.Sequential)]
    public struct CVector3 {
        public Single fX { get; set; }
        public Single fY { get; set; }
        public Single fZ { get; set; }
    }
}
