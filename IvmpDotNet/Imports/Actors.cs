using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace IvmpDotNet.Imports {
    public static class Actors {
        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort Actors_Create(Int32 iModelId, CVector3 vecPosition, Single fHeading);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Actors_Delete(ushort actorId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Actors_IsValid(ushort actorId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Actors_SetCoordinates(ushort actorId, CVector3 vecPosition);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Actors_SetHeading(ushort actorId, Single fHeading);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Actors_WalkToCoordinates(ushort playerId, ushort actorId, CVector3 vecPosition, Int32 iType);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern CVector3 Actors_GetCoordinates(ushort actorId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Single Actors_GetHeading(ushort actorId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Actors_GetModel(ushort actorId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Actors_SetName(ushort actorId, String szName);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Actors_GetName(ushort actorId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Actors_ToggleNametag(ushort actorId, Boolean bShow);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Actors_ToggleBlip(ushort actorId, Boolean bShow);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Actors_SetColor(ushort actorId, Int32 color);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Actors_GetColor(ushort actorId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Actors_ToggleFrozen(ushort actorId, Boolean frozen);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Actors_ToggleHelmet(ushort actorId, Boolean helmet);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Actors_WarpIntoVehicle(ushort actorId, Int32 vehicleid, Int32 seatid);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Actors_RemoveFromVehicle(ushort actorId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Actors_DriveToCoordinates(ushort actorId, CVector3 vecDriveTo, CVector3 vecDriveRot, Boolean bStop);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Actors_ForceAnim(ushort actorId, String szGroup, String szAnim);

    }
}
