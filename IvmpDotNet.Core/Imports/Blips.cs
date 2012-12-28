using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace IvmpDotNet.Imports {
    public static class Blips {
        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort Blips_Create(Int32 iSprite, CVector3 vecPosition, Boolean bShow);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Blips_Delete(ushort blipId);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Blips_SetCoordinates(ushort blipId, CVector3 vecPosition);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern CVector3 Blips_GetCoordinates(ushort blipId);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Blips_SetColor(ushort blipId, Int32 iColor, ushort playerId);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Blips_GetColor(ushort blipId);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Blips_SetSize(ushort blipId, Single fSize, ushort playerId);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Single Blips_GetSize(ushort blipId);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Blips_ToggleShortRange(ushort blipId, Boolean bToggle, ushort playerId);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Blips_ToggleRoute(ushort blipId, Boolean bToggle, ushort playerId);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Blips_SetName(ushort blipId, String szName, ushort playerId);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Blips_GetName(ushort blipId);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Blips_CreatePlayerBlip(ushort playerId, Int32 iSprite);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Blips_DeletePlayerBlip(ushort playerId);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Blips_TogglePlayerBlipDisplay(ushort playerId, Boolean bToggle);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Blips_TogglePlayerShortRange(ushort playerId, Boolean bToggle);

    }
}
