using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace IvmpDotNet.Imports {
    public static class Server {
        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Server_Log(String text);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Server_LogF(String text);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Server_AddRule(String rule, String value);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Server_RemoveRule(String rule);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Server_SetRule(String rule, String value);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Server_GetRule(String rule);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Server_SetPassword(String pass);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Server_SetHostName(String szHostname);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Server_TogglePayAndSpray(Boolean toggle);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Server_ToggleAutoAim(Boolean toggle);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Server_SendInput(String input);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Server_GetWeaponName(Int32 iWeaponId);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Server_GetVehicleName(Int32 iModelId);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Server_ToggleFrequentEvents(Boolean bToggle);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Server_SetWeather(Int32 iWeather);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Server_ForceWind(Single fWind);
    }
}
