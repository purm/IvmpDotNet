using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace IvmpDotNet.Imports {
    public static class GetPlayerManager {
        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetPlayerManager_DoesExist(ushort playerId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GetPlayerManager_Add(ushort playerId, String sPlayerName);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetPlayerManager_Remove(ushort playerId, Byte byteReason);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean GetPlayerManager_IsNameInUse(String szNick);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort GetPlayerManager_GetPlayerFromName(String sNick);
    }
}
