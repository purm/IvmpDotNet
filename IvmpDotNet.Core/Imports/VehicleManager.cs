using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace IvmpDotNet.Imports {
	public static class GetVehicleManager {
        //[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        //public static extern ushort GetVehicleManager_Add(Int32 iModelId, CVector3 vecSpawnPosition, CVector3 vecSpawnRotation, Byte byteColor1, Byte byteColor2, Byte byteColor3, Byte byteColor4, Int32 respawn_delay);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern void GetVehicleManager_Remove(ushort vehicleId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean GetVehicleManager_DoesExist(ushort vehicleId);

        //[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        //public static extern IntPtr GetVehicleManager_GetAt(ushort vehicleId);
	}
}
