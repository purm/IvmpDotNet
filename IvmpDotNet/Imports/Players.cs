using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace IvmpDotNet.Imports {
	public static class Players {
		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_IsConnected(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern String Players_GetName(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetName(ushort playerId, String szName);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_GiveWeapon(ushort playerId, Int32 iWeaponId, Int32 iAmmo);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_RemoveWeapons(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetWantedLevel(ushort playerId, Int32 iWantedLevel);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetHealth(ushort playerId, Int32 iHealth);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Int32 Players_GetHealth(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetArmour(ushort playerId, Int32 iArmour);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Int32 Players_GetArmour(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetCoordinates(ushort playerId, CVector3 vecPos);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern CVector3 Players_GetCoordinates(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetTime(ushort playerId, Byte iHour, Byte iMinute);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetWeather(ushort playerId, Byte iWeather);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetGravity(ushort playerId, Single fGravity);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SendMessage(ushort playerId, String szMessage, Int32 iColor, Boolean sqbAllowFormatting);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SendMessageToAll(String szMessage, Int32 iColor, Boolean sqbAllowFormatting);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_IsInAnyVehicle(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_IsInVehicle(ushort playerId, ushort vehicleId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern ushort Players_GetVehicleId(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Int32 Players_GetSeatId(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_IsOnFoot(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_TogglePayAndSpray(ushort playerId, Boolean sqbToggle);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_ToggleAutoAim(ushort playerId, Boolean sqbToggle);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetSpawnLocation(ushort playerId, CVector3 vecPos, Single fRotation);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetModel(ushort playerId, Int32 iModelId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Int32 Players_GetModel(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_ToggleControls(ushort playerId, Boolean sqbControls);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_IsSpawned(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetHeading(ushort playerId, Single fHeading);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Single Players_GetHeading(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_TogglePhysics(ushort playerId, Boolean sqbToggle);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_Kick(ushort playerId, Boolean sqbKickMessage);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_Ban(ushort playerId, UInt32 uiSeconds);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern String Players_GetIp(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_GiveMoney(ushort playerId, Int32 iMoney);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetMoney(ushort playerId, Int32 iMoney);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_ResetMoney(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Int32 Players_GetMoney(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_ToggleFrozen(ushort playerId, Boolean sqbPlayerFrozen, Boolean sqbCameraFrozen);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Int32 Players_GetState(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_DisplayText(ushort playerId, Single fPosX, Single fPosY, String szText, Int32 iTime);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_DisplayTextForAll(Single fPosX, Single fPosY, String szText, Int32 iTime);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_DisplayInfoText(ushort playerId, String szText, Int32 iTime);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_DisplayInfoTextForAll(String szText, Int32 iTime);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetVelocity(ushort playerId, CVector3 vecMoveSpeed);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern CVector3 Players_GetVelocity(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_WarpIntoVehicle(ushort playerId, ushort vehicleId, Int32 iSeatId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_RemoveFromVehicle(ushort playerId, Boolean bGraceful);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Int32 Players_GetWeapon(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Int32 Players_GetAmmo(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern String Players_GetSerial(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetCameraBehind(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetDucking(ushort playerId, Boolean sqbDucking);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_IsDucking(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetInvincible(ushort playerId, Boolean sqbInvincible);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_ToggleHUD(ushort playerId, Boolean sqbToggle);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_ToggleRadar(ushort playerId, Boolean sqbToggle);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_ToggleNames(ushort playerId, Boolean sqbToggle);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_ToggleAreaNames(ushort playerId, Boolean sqbToggle);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetColor(ushort playerId, Int32 color);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Int32 Players_GetColor(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Int32 Players_GetPing(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetClothes(ushort iPlayerId, Int32 iBodyPart, Int32 iClothes);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr Players_GetClothes(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_ResetClothes(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_Respawn(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_GiveHelmet(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_RemoveHelmet(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_ToggleHelmet(ushort playerId, Boolean sqbToggle);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetCameraPos(ushort playerId, CVector3 vecPos);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetCameraLookAt(ushort playerId, CVector3 vecPos);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_ResetCamera(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern CControlState Players_GetPreviousControlState(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern CControlState Players_GetControlState(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_TriggerEvent(ushort playerid, String szEventName, String szFormat);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_forceAnim(ushort playerId, String szGroup, String szAnim);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_requestAnim(ushort playerId);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_triggerAudioEvent(ushort playerId, String szAudio);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_triggerMissionCompleteAudio(ushort playerId, Int32 iMission);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_triggerPoliceReport(ushort playerId, String szAudio);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_fadeScreenIn(ushort playerId, Int32 iDuration);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_fadeScreenOut(ushort playerId, Int32 iDuration);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_blockWeaponChange(ushort playerId, Boolean btoggle);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_blockWeaponDrop(ushort playerId, Boolean btoggle);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Boolean Players_SetDimension(ushort playerId, Byte ucDimension);

		[DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern Int32 Players_GetDimension(ushort playerId);
	}
}
