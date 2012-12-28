using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvmpDotNet.Imports;

namespace IvmpDotNet.Wrappings {
    public class Player : IvmpDotNet.SDK.IPlayer {
        public ushort PlayerId {
            get;
            set;
        }

        public bool IsConnected {
            get { return Imports.Players.Players_IsConnected(this.PlayerId); }
        }

        public string Name {
            get {
                return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(Imports.Players.Players_GetName(this.PlayerId));
            }
            set {
                Imports.Players.Players_SetName(this.PlayerId, value);
            }
        }

        public bool GiveWeapon(int iWeaponId, int iAmmo) {
            return Imports.Players.Players_GiveWeapon(this.PlayerId, iWeaponId, iAmmo);
        }

        public bool RemoveWeapons() {
            return Imports.Players.Players_RemoveWeapons(this.PlayerId);
        }

        public int Health {
            get {
                return Players.Players_GetHealth(this.PlayerId);
            }
            set {
                Players.Players_SetHealth(this.PlayerId, value);
            }
        }

        public int Armour {
            get {
                return Players.Players_GetArmour(this.PlayerId);
            }
            set {
                Players.Players_SetArmour(this.PlayerId, value);
            }
        }

        public int WantedLevel {
            set { Players.Players_SetWantedLevel(this.PlayerId, value); }
        }

        public SDK.CVector3 Coordinates {
            get {
                return Players.Players_GetCoordinates(this.PlayerId);
            }
            set {
                Players.Players_SetCoordinates(this.PlayerId, value);
            }
        }

        public byte Weather {
            set { Players.Players_SetWeather(this.PlayerId, value); }
        }

        public float Gravity {
            set { Players.Players_SetGravity(this.PlayerId, value); }
        }

        public bool IsInAnyVehicle {
            get { return Players.Players_IsInAnyVehicle(this.PlayerId); }
        }

        public ushort VehicleId {
            get { return Players.Players_GetVehicleId(this.PlayerId); }
        }

        public int SeatId {
            get { return Players.Players_GetSeatId(this.PlayerId); }
        }

        public bool IsOnFoot {
            get { return Players.Players_IsOnFoot(this.PlayerId); }
        }

        public bool PayAndSpray {
            set { Players.Players_TogglePayAndSpray(this.PlayerId, value); }
        }

        public bool AutoAim {
            set { Players.Players_ToggleAutoAim(PlayerId, value); }
        }

        public int Model {
            get {
                return Players.Players_GetModel(PlayerId);
            }
            set {
                Players.Players_SetModel(PlayerId, value);
            }
        }

        public bool Controls {
            set { Players.Players_ToggleControls(PlayerId, true); }
        }

        public bool IsSpawned {
            get { return Players.Players_IsSpawned(PlayerId); }
        }

        public float Heading {
            get {
                return Players.Players_GetHeading(PlayerId);
            }
            set {
                Players.Players_SetHeading(PlayerId, value);
            }
        }

        public bool Phsysics {
            set { Players.Players_TogglePhysics(PlayerId, value); }
        }

        public string Ip {
            get { return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(Players.Players_GetIp(PlayerId)); }
        }

        public int Money {
            get {
                return Players.Players_GetMoney(PlayerId);
            }
            set {
                Players.Players_SetMoney(PlayerId, value);
            }
        }

        public int State {
            get { return Players.Players_GetState(PlayerId); }
        }

        public SDK.CVector3 Velocty {
            get {
                return Players.Players_GetVelocity(PlayerId);
            }
            set {
                Players.Players_SetVelocity(PlayerId, value);
            }
        }

        public int Weapon {
            get { return Players.Players_GetWeapon(PlayerId); }
        }

        public int Ammo {
            get { return Players.Players_GetAmmo(PlayerId); }
        }

        public string Serial {
            get { return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(Players.Players_GetSerial(PlayerId)); }
        }

        public bool Ducking {
            get {
                return Players.Players_IsDucking(PlayerId);
            }
            set {
                Players.Players_SetDucking(PlayerId, value);
            }
        }

        public bool Invincible {
            set { Players.Players_SetInvincible(PlayerId, value); }
        }

        public bool HUD {
            set { Players.Players_ToggleHUD(PlayerId, value); }
        }

        public bool Radar {
            set { Players.Players_ToggleRadar(PlayerId, value); }
        }

        public bool Names {
            set { Players.Players_ToggleNames(PlayerId, value); }
        }

        public bool AreaNames {
            set { Players.Players_ToggleAreaNames(PlayerId, value); }
        }

        public int Color {
            get {
                return Players.Players_GetColor(PlayerId);
            }
            set {
                Players.Players_SetColor(PlayerId, value);
            }
        }

        public int[] Clothes {
            get { throw new NotImplementedException(); }
        }

        public int Ping {
            get { return Players.Players_GetPing(PlayerId); }
        }

        public bool Helmet {
            set {
                Players.Players_ToggleHelmet(PlayerId, value);
            }
        }

        public SDK.CVector3 CameraPos {
            set { Players.Players_SetCameraPos(PlayerId, value); }
        }

        public SDK.CVector3 CameraLookAt {
            set { Players.Players_SetCameraLookAt(PlayerId, value); }
        }

        public SDK.CControlState PreviousControlState {
            get { return Players.Players_GetPreviousControlState(PlayerId); }
        }

        public SDK.CControlState ControlState {
            get { return Players.Players_GetControlState(PlayerId); }
        }

        public int Dimension {
            get {
                return Players.Players_GetDimension(PlayerId);
            }
            set {
                Players.Players_SetDimension(PlayerId, (byte)value);
            }
        }

        public bool BlockWeaponDrop(bool btoggle) {
            return Players.Players_blockWeaponDrop(PlayerId, btoggle);
        }

        public bool BlockWeaponChange(bool btoggle) {
            return Players.Players_blockWeaponChange(PlayerId, btoggle);
        }

        public bool FadeScreenOut(int iDuration) {
            return Players.Players_fadeScreenOut(PlayerId, iDuration);
        }

        public bool FadeScreenIn(int iDuration) {
            return Players.Players_fadeScreenIn(PlayerId, iDuration);
        }

        public bool TriggerPoliceReport(string szAudio) {
            return Players.Players_triggerPoliceReport(PlayerId, szAudio);
        }

        public bool TriggerMissionCompleteAudio(int iMission) {
            return Players.Players_triggerMissionCompleteAudio(PlayerId, iMission);
        }

        public bool TriggerAudioEvent(string szAudio) {
            return Players.Players_triggerAudioEvent(PlayerId, szAudio);
        }

        public bool RequestAnim() {
            return Players.Players_requestAnim(PlayerId);
        }

        public bool ForceAnim(string szGroup, string szAnim) {
            return Players.Players_forceAnim(PlayerId, szGroup, szAnim);
        }

        public bool TriggerEvent(string szEventName, string szFormat) {
            return Players.Players_TriggerEvent(PlayerId, szEventName, szFormat);
        }

        public bool ResetCamera() {
            return Players.Players_ResetCamera(PlayerId);
        }

        public bool RemoveHelmet() {
            return Players.Players_RemoveHelmet(PlayerId);
        }

        public bool Respawn() {
            return Players.Players_Respawn(PlayerId);
        }

        public bool GiveHelmet() {
            return Players.Players_GiveHelmet(PlayerId);
        }

        public bool ResetClothes() {
            return Players.Players_ResetClothes(PlayerId);
        }

        public bool SetClothes(int iBodyPart, int iClothes) {
            return Players.Players_SetClothes(PlayerId, iBodyPart, iClothes);
        }

        public bool SetCameraBehind() {
            return Players.Players_SetCameraBehind(PlayerId);
        }

        public bool RemoveFromVehicle(bool bGraceful) {
            return Players.Players_RemoveFromVehicle(PlayerId, bGraceful);
        }

        public bool WarpIntoVehicle(ushort vehicleId, int iSeatId) {
            return Players.Players_WarpIntoVehicle(PlayerId, vehicleId, iSeatId);
        }

        public bool DisplayText(float fPosX, float fPosY, string szText, int iTime) {
            return Players.Players_DisplayText(PlayerId, fPosX, fPosY, szText, iTime);
        }

        public bool ToggleFrozen(bool sqbPlayerFrozen, bool sqbCameraFrozen) {
            return Players.Players_ToggleFrozen(PlayerId, sqbPlayerFrozen, sqbCameraFrozen);
        }

        public bool GiveMoney(int iMoney) {
            return Players.Players_GiveMoney(PlayerId, iMoney);
        }

        public bool ResetMoney() {
            return Players.Players_ResetMoney(PlayerId);
        }

        public bool SetSpawnLocation(SDK.CVector3 vecPos, float fRotation) {
            return Players.Players_SetSpawnLocation(PlayerId, vecPos, fRotation);
        }

        public bool IsInVehicle(ushort vehicleId) {
            return Players.Players_IsInVehicle(PlayerId, vehicleId);
        }

        public bool SetTime(byte iHour, byte iMinute) {
            return Players.Players_SetTime(PlayerId, iHour, iMinute);
        }

        public bool SendMessage(string szMessage, int iColor, bool sqbAllowFormatting) {
            return Players.Players_SendMessage(PlayerId, szMessage, iColor, sqbAllowFormatting);
        }

        public bool Kick(bool sqbKickMessage) {
            return Players.Players_Kick(PlayerId, sqbKickMessage);
        }

        public bool Ban(uint uiSeconds) {
            return Players.Players_Ban(PlayerId, uiSeconds);
        }


        public bool CreatePlayerBlip(int iSprite) {
            return Blips.Blips_CreatePlayerBlip(PlayerId, iSprite);
        }

        public bool DeletePlayerBlip() {
            return Blips.Blips_DeletePlayerBlip(PlayerId);
        }

        public bool TogglePlayerBlipDisplay(bool bToggle) {
            return Blips.Blips_TogglePlayerBlipDisplay(PlayerId, bToggle);
        }

        public bool TogglePlayerShortRange(bool bToggle) {
            return Blips.Blips_TogglePlayerShortRange(PlayerId, bToggle);
        }
    }
}
