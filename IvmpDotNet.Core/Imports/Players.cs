using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace IvmpDotNet.Imports {
	public static class Players {
		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_IsConnected(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Players_GetName(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetName(ushort playerId, String szName);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_GiveWeapon(ushort playerId, Int32 iWeaponId, Int32 iAmmo);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_RemoveWeapons(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetWantedLevel(ushort playerId, Int32 iWantedLevel);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetHealth(ushort playerId, Int32 iHealth);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Int32 Players_GetHealth(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetArmour(ushort playerId, Int32 iArmour);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Int32 Players_GetArmour(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetCoordinates(ushort playerId, CVector3 vecPos);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern CVector3 Players_GetCoordinates(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetTime(ushort playerId, Byte iHour, Byte iMinute);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetWeather(ushort playerId, Byte iWeather);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetGravity(ushort playerId, Single fGravity);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SendMessage(ushort playerId, String szMessage, Int32 iColor, Boolean sqbAllowFormatting);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SendMessageToAll(String szMessage, Int32 iColor, Boolean sqbAllowFormatting);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_IsInAnyVehicle(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_IsInVehicle(ushort playerId, ushort vehicleId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern ushort Players_GetVehicleId(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Int32 Players_GetSeatId(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_IsOnFoot(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_TogglePayAndSpray(ushort playerId, Boolean sqbToggle);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_ToggleAutoAim(ushort playerId, Boolean sqbToggle);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetSpawnLocation(ushort playerId, CVector3 vecPos, Single fRotation);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetModel(ushort playerId, Int32 iModelId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Int32 Players_GetModel(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_ToggleControls(ushort playerId, Boolean sqbControls);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_IsSpawned(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetHeading(ushort playerId, Single fHeading);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Single Players_GetHeading(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_TogglePhysics(ushort playerId, Boolean sqbToggle);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_Kick(ushort playerId, Boolean sqbKickMessage);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_Ban(ushort playerId, UInt32 uiSeconds);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Players_GetIp(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_GiveMoney(ushort playerId, Int32 iMoney);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetMoney(ushort playerId, Int32 iMoney);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_ResetMoney(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Int32 Players_GetMoney(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_ToggleFrozen(ushort playerId, Boolean sqbPlayerFrozen, Boolean sqbCameraFrozen);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Int32 Players_GetState(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_DisplayText(ushort playerId, Single fPosX, Single fPosY, String szText, Int32 iTime);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_DisplayTextForAll(Single fPosX, Single fPosY, String szText, Int32 iTime);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_DisplayInfoText(ushort playerId, String szText, Int32 iTime);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_DisplayInfoTextForAll(String szText, Int32 iTime);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetVelocity(ushort playerId, CVector3 vecMoveSpeed);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern CVector3 Players_GetVelocity(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_WarpIntoVehicle(ushort playerId, ushort vehicleId, Int32 iSeatId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_RemoveFromVehicle(ushort playerId, Boolean bGraceful);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Int32 Players_GetWeapon(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Int32 Players_GetAmmo(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Players_GetSerial(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetCameraBehind(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetDucking(ushort playerId, Boolean sqbDucking);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_IsDucking(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetInvincible(ushort playerId, Boolean sqbInvincible);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_ToggleHUD(ushort playerId, Boolean sqbToggle);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_ToggleRadar(ushort playerId, Boolean sqbToggle);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_ToggleNames(ushort playerId, Boolean sqbToggle);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_ToggleAreaNames(ushort playerId, Boolean sqbToggle);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetColor(ushort playerId, Int32 color);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Int32 Players_GetColor(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Int32 Players_GetPing(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetClothes(ushort iPlayerId, Int32 iBodyPart, Int32 iClothes);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr Players_GetClothes(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_ResetClothes(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_Respawn(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_GiveHelmet(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_RemoveHelmet(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_ToggleHelmet(ushort playerId, Boolean sqbToggle);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetCameraPos(ushort playerId, CVector3 vecPos);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetCameraLookAt(ushort playerId, CVector3 vecPos);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_ResetCamera(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern CControlState Players_GetPreviousControlState(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern CControlState Players_GetControlState(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_TriggerEvent(ushort playerid, String szEventName, String szFormat);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_forceAnim(ushort playerId, String szGroup, String szAnim);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_requestAnim(ushort playerId);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_triggerAudioEvent(ushort playerId, String szAudio);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_triggerMissionCompleteAudio(ushort playerId, Int32 iMission);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_triggerPoliceReport(ushort playerId, String szAudio);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_fadeScreenIn(ushort playerId, Int32 iDuration);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_fadeScreenOut(ushort playerId, Int32 iDuration);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_blockWeaponChange(ushort playerId, Boolean btoggle);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_blockWeaponDrop(ushort playerId, Boolean btoggle);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetDimension(ushort playerId, Byte ucDimension);

		[DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
		public static extern Int32 Players_GetDimension(ushort playerId);
	}
}
