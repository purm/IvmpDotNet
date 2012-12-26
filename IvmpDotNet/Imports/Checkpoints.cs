using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace IvmpDotNet.Imports {
    public static class Checkpoints {
        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort Checkpoints_Create(Int32 iType, CVector3 vecPosition, CVector3 vecTargetPosition, Single fRadius);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Checkpoints_Delete(ushort checkpointId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Checkpoints_ShowForPlayer(ushort checkpointId, ushort playerId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Checkpoints_HideForPlayer(ushort checkpointId, ushort playerId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Checkpoints_ShowForAll(ushort checkpointId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Checkpoints_HideForAll(ushort checkpointId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Checkpoints_SetType(ushort checkpointId, Int32 iType);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Checkpoints_GetType(ushort checkpointId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Checkpoints_SetPosition(ushort checkpointId, CVector3 vecPosition);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern CVector3 Checkpoints_GetPosition(ushort checkpointId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Checkpoints_SetTargetPosition(ushort checkpointId, CVector3 vecTargetPosition);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern CVector3 Checkpoints_GetTargetPosition(ushort checkpointId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Checkpoints_SetRadius(ushort checkpointId, Single fRadius);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Single Checkpoints_GetRadius(ushort checkpointId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Checkpoints_SetDimension(ushort checkpointId, Byte ucDimension);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Checkpoints_GetDimension(ushort checkpointId);

    }
}
