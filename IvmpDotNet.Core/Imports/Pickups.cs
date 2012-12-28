using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace IvmpDotNet.Imports {
    public static class Pickups {
        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort Pickups_Create(long modelhash, Byte type, UInt32 value, CVector3 vecPosition, CVector3 vecRotation);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Pickups_Delete(ushort pickupid);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Pickups_GetModel(ushort pickupid);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Pickups_GetType(ushort pickupid);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Pickups_SetValue(ushort pickupid, UInt32 pvalue);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 Pickups_GetValue(ushort pickupid);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Pickups_SetCoordinates(ushort pickupid, CVector3 vecPosition);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern CVector3 Pickups_GetCoordinates(ushort pickupid);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Pickups_SetRotation(ushort pickupid, CVector3 vecPosition);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern CVector3 Pickups_GetRotation(ushort pickupid);
    }
}
