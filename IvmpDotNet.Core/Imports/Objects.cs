using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace IvmpDotNet.Imports {
    public static class Objects {
        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort Objects_Create(Int64 modelhash, CVector3 vecPosition, CVector3 vecRotation);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Objects_Delete(ushort objectId);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Objects_GetModel(ushort objectId);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Objects_SetCoordinates(ushort objectId, CVector3 vecPosition);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern CVector3 Objects_GetCoordinates(ushort objectId);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Objects_SetRotation(ushort objectId, CVector3 vecRotation);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern CVector3 Objects_GetRotation(ushort objectId);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Objects_CreateExplosion(CVector3 vecPos, Single fDensity);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort Objects_CreateFire(CVector3 vecPos, Single fDensity);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void Objects_DeleteFire(ushort fireId);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Objects_AttachPed(ushort objectId, ushort playerId, CVector3 vecPos, CVector3 vecRot);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Objects_AttachVehicle(ushort objectId, ushort vehicleId, CVector3 vecPos, CVector3 vecRot);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Objects_Move(ushort objectId, CVector3 vecMoveTarget, CVector3 vecMoveRot, Single fSpeed);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Objects_Rotate(ushort objectId, CVector3 vecRotation, Single fSpeed);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Objects_AttachToPlayer(ushort objectId, ushort playerId, CVector3 vecPos, CVector3 vecRot, Int32 iBone);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Objects_SetDimension(ushort objectId, Byte ucDimension);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Byte Objects_GetDimension(ushort objectId);
    }
}
