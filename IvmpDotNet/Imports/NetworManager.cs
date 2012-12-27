using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.Imports {
    public static class NetworManager {
        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern bool NetworkManager_AddBan(String strIp, uint uiSeconds);
    }
}
