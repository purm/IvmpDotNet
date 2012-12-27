using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    public interface IPlayer {
        ushort PlayerId { get; set; }

        bool IsConnected { get; }
        string Name { get; set; }
        int Health { get; set; }
        int Armour { get; set; }
        int WantedLevel { set; }
        CVector3 Coordinates { get; set; }
        byte Weather { set; }
        Single Gravity { set; }
        bool IsInAnyVehicle { get; }
        ushort VehicleId { get; }
        int SeatId { get; }
        bool IsOnFoot { get; }
        bool PayAndSpray { set; }
        bool AutoAim { set; }
        int Model { get; set; }
        bool Controls { set; }
        bool IsSpawned { get; }
        Single Heading { get; set; }
        bool Phsysics { set; }
        string Ip { get; }
        int Money { get; set; }
        int State { get; }
        CVector3 Velocty { get; set; }
        int Weapon { get; }
        int Ammo { get; }
        string Serial { get; }
        bool Ducking { set; get; }
        bool Invincible { set; }
        bool HUD { set; }
        bool Radar { set; }
        bool Names { set; }
        bool AreaNames { set; }
        int Color { get; set; }
        int[] Clothes { get; }
        int Ping { get; }
        bool Helmet { set; }
        CVector3 CameraPos { set; }
        CVector3 CameraLookAt { set; }
        CControlState PreviousControlState { get; }
        CControlState ControlState { get; }
        int Dimension { get; set; }

        bool BlockWeaponDrop(Boolean btoggle);
        bool BlockWeaponChange(Boolean btoggle);
        bool FadeScreenOut(Int32 iDuration);
        bool FadeScreenIn(Int32 iDuration);
        bool TriggerPoliceReport(String szAudio);
        bool TriggerMissionCompleteAudio(Int32 iMission);
        bool TriggerAudioEvent(String szAudio);
        bool RequestAnim();
        bool ForceAnim(String szGroup, String szAnim);
        bool TriggerEvent(String szEventName, String szFormat);
        bool ResetCamera();
        bool RemoveHelmet();
        bool Respawn();
        bool GiveHelmet();
        bool ResetClothes();
        bool SetClothes(Int32 iBodyPart, Int32 iClothes);
        bool SetCameraBehind();
        bool RemoveFromVehicle(Boolean bGraceful);
        bool WarpIntoVehicle(ushort vehicleId, Int32 iSeatId);
        bool DisplayText(Single fPosX, Single fPosY, String szText, Int32 iTime);
        bool ToggleFrozen(Boolean sqbPlayerFrozen, Boolean sqbCameraFrozen);
        bool GiveMoney(Int32 iMoney);
        bool ResetMoney();
        bool SetSpawnLocation(CVector3 vecPos, Single fRotation);
        bool IsInVehicle(ushort vehicleId);
        bool GiveWeapon(Int32 iWeaponId, Int32 iAmmo);
        bool RemoveWeapons();
        bool SetTime(Byte iHour, Byte iMinute);
        bool SendMessage(String szMessage, Int32 iColor, Boolean sqbAllowFormatting);
        bool Kick(Boolean sqbKickMessage);
        bool Ban(UInt32 uiSeconds);

        bool CreatePlayerBlip(Int32 iSprite);
        bool DeletePlayerBlip();
        bool TogglePlayerBlipDisplay(Boolean bToggle);
        bool TogglePlayerShortRange(Boolean bToggle);
    }
}
