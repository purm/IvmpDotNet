using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Represents a player
    /// </summary>
    public interface IPlayer {
        #region Properties

        /// <summary>
        /// Gets or sets the player's id
        /// </summary>
        ushort PlayerId { get; set; }

        /// <summary>
        /// Gets if the player is connected
        /// </summary>
        bool IsConnected { get; }

        /// <summary>
        /// Gets or sets the player's name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the player's Health
        /// </summary>
        int Health { get; set; }

        /// <summary>
        /// Gets or sets the player's armour
        /// </summary>
        int Armour { get; set; }

        /// <summary>
        /// sets the player's wanted level
        /// </summary>
        int WantedLevel { set; }

        /// <summary>
        /// Gets or sets the coordinates of the player
        /// </summary>
        CVector3 Coordinates { get; set; }

        /// <summary>
        /// Sets the player's weather
        /// </summary>
        byte Weather { set; }

        /// <summary>
        /// Sets the player's gravity
        /// </summary>
        Single Gravity { set; }

        /// <summary>
        /// Checks if the player is in a vehicle
        /// </summary>
        bool IsInAnyVehicle { get; }

        /// <summary>
        /// Gets the vehicle in wich the player is
        /// </summary>
        IVehicle Vehicle { get; }

        /// <summary>
        /// Gets the seat on which the player sits
        /// </summary>
        int SeatId { get; }

        /// <summary>
        /// Checks if the player is on foot
        /// </summary>
        bool IsOnFoot { get; }

        /// <summary>
        /// Toggles pay'n spray for the player
        /// </summary>
        bool PayAndSpray { set; }

        /// <summary>
        /// toggles autoaim for the player
        /// </summary>
        bool AutoAim { set; }

        /// <summary>
        /// Gets or sets the player's model
        /// </summary>
        int Model { get; set; }

        /// <summary>
        /// Toggles if the player is able to use his controls like mouse and keyboard
        /// </summary>
        bool Controls { set; }

        /// <summary>
        /// Checks if the player is spawned
        /// </summary>
        bool IsSpawned { get; }

        /// <summary>
        /// Gets or sets the player's heading
        /// </summary>
        Single Heading { get; set; }

        /// <summary>
        /// Toggles the player's Physics.
        /// </summary>
        bool Phsysics { set; }

        /// <summary>
        /// Gets the player's ip
        /// </summary>
        string Ip { get; }

        /// <summary>
        /// Gets or sets the player's money
        /// </summary>
        int Money { get; set; }

        /// <summary>
        /// Gets the players state
        /// </summary>
        StateTypes State { get; }

        /// <summary>
        /// Gets or sets the players velocity
        /// </summary>
        CVector3 Velocity { get; set; }

        /// <summary>
        /// Gets the players current weapon
        /// </summary>
        Weapons Weapon { get; }

        /// <summary>
        /// Gets the amount of ammo a player has.
        /// </summary>
        int Ammo { get; }

        /// <summary>
        /// Gets the player's serial
        /// </summary>
        string Serial { get; }

        /// <summary>
        /// Gets or sets if the player is ducking
        /// </summary>
        bool Ducking { set; get; }

        /// <summary>
        /// Makes the player Invincible
        /// </summary>
        bool Invincible { set; }

        /// <summary>
        /// Toggles the player's HUD
        /// </summary>
        bool HUD { set; }

        /// <summary>
        /// Toggles the player's radar
        /// </summary>
        bool Radar { set; }

        /// <summary>
        /// Toggles the player's name tags.
        /// </summary>
        bool Names { set; }

        /// <summary>
        /// Toggles the players areanames.
        /// </summary>
        bool AreaNames { set; }

        /// <summary>
        /// Gets or sets the player's color
        /// </summary>
        int Color { get; set; }

        /// <summary>
        /// Gets the player's clothes
        /// </summary>
        Dictionary<Bodyparts, int> Clothes { get; }

        /// <summary>
        /// Gets the player's ping
        /// </summary>
        int Ping { get; }

        /// <summary>
        /// Toggles the players helmet
        /// </summary>
        bool Helmet { set; }

        /// <summary>
        /// Sets the player's camera position
        /// </summary>
        CVector3 CameraPos { set; }

        /// <summary>
        /// Sets the lookAt position of the player's camera
        /// </summary>
        CVector3 CameraLookAt { set; }

        /// <summary>
        /// Gets the previous control state
        /// </summary>
        CControlState PreviousControlState { get; }

        /// <summary>
        /// GEts the current control state
        /// </summary>
        CControlState ControlState { get; }

        /// <summary>
        /// Gets or sets the players dimension
        /// </summary>
        int Dimension { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// blocks or enables dropping of weapons on death for the player.
        /// </summary>
        /// <param name="btoggle">true = drop</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool BlockWeaponDrop(Boolean btoggle);

        /// <summary>
        /// Blocks or enables the scrolling of weapons for the player.
        /// </summary>
        /// <param name="btoggle">true = enable</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool BlockWeaponChange(Boolean btoggle);

        /// <summary>
        /// Fades the screen out for the player.
        /// </summary>
        /// <param name="iDuration">The duration of the effect</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool FadeScreenOut(Int32 iDuration);

        /// <summary>
        /// Fades the screen in for the player.
        /// </summary>
        /// <param name="iDuration">The duration of the effect</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool FadeScreenIn(Int32 iDuration);

        /// <summary>
        /// Plays a police report for the player.
        /// </summary>
        /// <param name="szAudio">the police report audio</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool TriggerPoliceReport(String szAudio);

        /// <summary>
        /// Plays a mission sound for the player.
        /// </summary>
        /// <param name="iMission">the missionid sound</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool TriggerMissionCompleteAudio(Int32 iMission);

        /// <summary>
        /// Plays a game sound for the player.
        /// </summary>
        /// <param name="szAudio">the game sound to play</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool TriggerAudioEvent(String szAudio);

        /// <summary>
        /// Prepares the use of an animation for the player.
        /// </summary>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool RequestAnim();

        /// <summary>
        /// Sets the animation of the player.
        /// </summary>
        /// <param name="szGroup">the group of the animation</param>
        /// <param name="szAnim">the name of the animation</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool ForceAnim(String szGroup, String szAnim);

        /// <summary>
        /// *TODO*
        /// </summary>
        /// <param name="szEventName"></param>
        /// <param name="szFormat"></param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool TriggerEvent(String szEventName, String szFormat);

        /// <summary>
        /// Resets the player's camera behind him.
        /// </summary>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool ResetCamera();

        /// <summary>
        /// removes a helmet from the player.
        /// </summary>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool RemoveHelmet();

        /// <summary>
        /// Respawns the player
        /// </summary>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool Respawn();

        /// <summary>
        /// Gives a helmet to the player
        /// </summary>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool GiveHelmet();

        /// <summary>
        /// Resets the player's clothes
        /// </summary>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool ResetClothes();

        /// <summary>
        /// Sets a cloth for a bodypart
        /// </summary>
        /// <param name="iBodyPart">The bodypart</param>
        /// <param name="iClothes">the cloth to wear</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool SetClothes(Bodyparts iBodyPart, Int32 iClothes);

        /// <summary>
        /// Sets the camera behind the player
        /// </summary>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool SetCameraBehind();

        /// <summary>
        /// Removes the player from vehicle
        /// </summary>
        /// <param name="bGraceful">if set to true, the player exits the vehicle normally (with an anim), if no parameter or false is given the player is warped out.</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool RemoveFromVehicle(Boolean bGraceful);

        /// <summary>
        /// Warps an player into a vehicle
        /// </summary>
        /// <param name="vehicle">vehicle to warp in</param>
        /// <param name="iSeatId">seat to sit on</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool WarpIntoVehicle(IVehicle vehicle, Int32 iSeatId);

        /// <summary>
        /// Displays a text for the player
        /// </summary>
        /// <param name="fPosX">X Pos</param>
        /// <param name="fPosY">Y Pos</param>
        /// <param name="szText">Text to display</param>
        /// <param name="iTime">how long the text shall be displayed in milliseconds</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool DisplayText(Single fPosX, Single fPosY, String szText, Int32 iTime);

        /// <summary>
        /// Toggles if the player is frozen
        /// </summary>
        /// <param name="sqbPlayerFrozen">true = freeze</param>
        /// <param name="sqbCameraFrozen">true = camera also frozen</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool ToggleFrozen(Boolean sqbPlayerFrozen, Boolean sqbCameraFrozen);

        /// <summary>
        /// Gives Money to the player
        /// </summary>
        /// <param name="iMoney">amount of money</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool GiveMoney(Int32 iMoney);

        /// <summary>
        /// Resets the player's money
        /// </summary>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool ResetMoney();

        /// <summary>
        /// Sets the player's spawn location
        /// </summary>
        /// <param name="vecPos">loaction to spawn</param>
        /// <param name="fRotation">rotation to spawn</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool SetSpawnLocation(CVector3 vecPos, Single fRotation);

        /// <summary>
        /// Checks if the player is in a specific vehicle
        /// </summary>
        /// <param name="vehicle">The vehicle to check for</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool IsInVehicle(IVehicle vehicle);

        /// <summary>
        /// Gives a weapon to the player
        /// </summary>
        /// <param name="iWeaponId">the type of weapon</param>
        /// <param name="iAmmo">the ammo for the weapon - warning: there are limitations for each weapon type(see wiki)</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool GiveWeapon(Weapons iWeaponId, Int32 iAmmo);

        /// <summary>
        /// Removes all weapons from the player
        /// </summary>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool RemoveWeapons();

        /// <summary>
        /// Sets the time for the player
        /// </summary>
        /// <param name="iHour">hour time</param>
        /// <param name="iMinute">minute time</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool SetTime(Byte iHour, Byte iMinute);

        /// <summary>
        /// Sends a message to the player
        /// </summary>
        /// <param name="szMessage">message to send</param>
        /// <param name="iColor">color to show the message</param>
        /// <param name="sqbAllowFormatting">true = formatting via syntax is possible</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool SendMessage(String szMessage, Int32 iColor, Boolean sqbAllowFormatting);

        /// <summary>
        /// Kicks the player from the server
        /// </summary>
        /// <param name="sqbKickMessage">boolean whether to send a connection message or not</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool Kick(Boolean sqbKickMessage);

        /// <summary>
        /// Bans the player from the server
        /// </summary>
        /// <param name="uiSeconds">time to ban in seconds</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool Ban(UInt32 uiSeconds);

        /// <summary>
        /// Creates a blip for the player
        /// </summary>
        /// <param name="iSprite">blip type</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool CreatePlayerBlip(Blips iSprite);

        /// <summary>
        /// Deletes the player blip
        /// </summary>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool DeletePlayerBlip();

        /// <summary>
        /// Toggles the player blip
        /// </summary>
        /// <param name="bToggle">true = display</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool TogglePlayerBlipDisplay(Boolean bToggle);

        /// <summary>
        /// Toggles short range for player blip
        /// </summary>
        /// <param name="bToggle">true = shortrange</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool TogglePlayerShortRange(Boolean bToggle);

        #endregion
    }
}
