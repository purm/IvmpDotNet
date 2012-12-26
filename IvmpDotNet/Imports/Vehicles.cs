using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace IvmpDotNet.Imports {
    public static class Vehicles {
        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Vehicles_Create(Int32 iModelId, CVector3 vecPosition, CVector3 vecRotation, Int32 color1, Int32 color2, Int32 color3, Int32 color4, Int32 respawn_delay);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_Delete(ushort vehicleid);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_SetCoordinates(ushort vehicleid, CVector3 vecPosition);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern CVector3 Vehicles_GetCoordinates(ushort vehicleid);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_SetRotation(ushort vehicleId, CVector3 vecRotation);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_SetDirtLevel(ushort vehicleid, Single fLevel);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Single Vehicles_GetDirtLevel(ushort vehicleId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_SetSirenState(ushort vehicleId, Boolean sqbState);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_GetSirenState(ushort vehicleId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_SoundHorn(ushort vehicleId, Int32 iDuration);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern CVector3 Vehicles_GetRotation(ushort vehicleId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_IsValid(ushort vehicleid);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_SetColor(ushort vehicleid, IntPtr colors);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Vehicles_GetColor(ushort vehicleid);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Vehicles_GetModel(ushort vehicleid);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_SetHealth(ushort vehicleid, Int32 health);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Vehicles_GetHealth(ushort vehicleid);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_SetVelocity(ushort vehicleid, CVector3 vecMoveSpeed);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern CVector3 Vehicles_GetVelocity(ushort vehicleid);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_SetAngularVelocity(ushort vehicleid, CVector3 vecTurnSpeed);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern CVector3 Vehicles_GetAngularVelocity(ushort vehicleid);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_Respawn(ushort vehicleId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_IsOccupied(ushort vehicleId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Vehicles_GetOccupants(ushort vehicleId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_SetLocked(ushort vehicleId, Int32 iLocked);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Vehicles_GetLocked(ushort vehicleId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_SetIndicators(ushort vehicleId, Boolean bFrontLeft, Boolean bFrontRight, Boolean bBackLeft, Boolean bBackRight);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Vehicles_GetIndicators(ushort vehicleId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_SetComponent(ushort vehicleId, Int32 iSlot, Boolean bOn);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_ResetComponents(ushort vehicleId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Vehicles_GetComponents(ushort vehicleId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_SetVariation(ushort vehicleId, Int32 iVariation);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Vehicles_GetVariation(ushort vehicleId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_SetEngineStatus(ushort vehicleId, Boolean bEngineStatusx);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_GetEngineStatus(ushort vehicleId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_SwitchTaxiLights(ushort vehicleId, Boolean check);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_ControlCarDoors(ushort vehicleId, Int32 door, Boolean door2, Single door3);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_SetLights(ushort vehicleId, Boolean bLights);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_GetLights(ushort vehicleId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_GetTaxiLights(ushort vehicleId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_RepairWheels(ushort vehicleId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_RepairWindows(ushort vehicleId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_Repair(ushort vehicleId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_SetDimension(ushort vehicleId, Int32 dimension);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Vehicles_GetDimension(ushort vehicleId);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Vehicles_SetRespawnDelay(ushort vehicleId, Int32 respawn_delay);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Int32 Vehicles_GetRespawnDelay(ushort vehicleId);
    }
}