using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Indicates that an event is only triggerd if "frequently events" are turned on
    /// </summary>
    [AttributeUsage(AttributeTargets.Event, AllowMultiple = false)]
    public class FrequentlyEventAttribute : Attribute { }

    /// <summary>
    /// a vehicle's doors
    /// </summary>
    public enum VehicleDoors : int {
        Driver = 0,
        FirstPassenger = 1,
        SecondPassenger = 2,
        ThirdPassenger = 3,
        Hood = 4,
        Trunk = 5
    }

    /// <summary>
    /// Locking states of vehicle doors
    /// </summary>
    public enum LockedState : int {
        Unlocked = 0,
        Locked = 1,
        LockedWithBreakableGlass = 2
    }

    /// <summary>
    /// weather types
    /// </summary>
    public enum WeatherTypes : int {
        ExtraSunny = 1,
        Sunny = 2,
        SunnyAndWindy = 3,
        Cloudy = 4,
        Raining = 5,
        Drizzle = 6,
        Foggy = 7,
        Thunderstorm = 8,
        ExtraSunny2 = 9,
        SunnyAndWindy2 = 10
    }

    /// <summary>
    /// Blip types
    /// </summary>
    public enum Blips : int {
        Destination = 0,
        Destination1 = 1,
        Destination2 = 2,
        Objective = 3,
        Objective1 = 4,
        Objective2 = 5,
        Player = 6,
        North = 7,
        Waypoint = 8,
        Pistol = 9,
        Shotgun = 10,
        Smg = 11,
        Rofle = 12,
        Rocket = 13,
        Grenade = 14,
        Molotov = 15,
        Sniper = 16,
        BaseballBat = 17,
        Knife = 18,
        Health = 19,
        Armor = 20,
        BurgerShot = 21,
        CluckinBell = 22,
        Vlad = 23,
        Internet = 24,
        Manny = 25,
        LittleJacob = 26,
        Roman = 27,
        Faustin = 28,
        Safehouse = 29,
        TaxiRank = 30,
        Bernie = 31,
        Brucie = 32,
        UnknownContact = 33,
        Dwayne = 34,
        Elizabeta = 35,
        Gambetti = 36,
        JimmyPegorino = 37,
        Derrick = 38,
        Francis = 39,
        Gerry = 40,
        Katie = 41,
        Packie = 42,
        PhilBell = 43,
        PlayboyX = 44,
        RayBoccino = 45,
        EightBall = 46,
        Bar = 47,
        BoatTour = 48,
        Bowling = 49,
        ClothesShop = 50,
        Club = 51,
        Darts = 52,
        DwayneRed = 53,
        Date = 54,
        PlayboXRed = 55,
        Helitour = 56,
        Restaurant = 57,
        Station = 58,
        Weapons = 59,
        PoliceStation = 60,
        FireStation = 61,
        Hospital = 62,
        Male = 63,
        Female = 64,
        FinishLine = 65,
        StripClub = 66,
        ConsoleGame = 67,
        CopCar = 68,
        Dimitri = 69,
        ComedyClub = 70,
        CabaretClub = 71,
        Ransom = 72,
        CopChopper = 73,
        Michelle = 74,
        PayNSpray = 75,
        Assassin = 76,
        Revenge = 77,
        Deal = 78,
        Garage = 79,
        Lawyer = 80,
        Trophy = 81,
        MultiplayerTutorial = 82,
        Station3 = 83,
        Station8 = 84,
        Stationa = 85,
        Stationb = 86,
        Stationc = 87,
        Statione = 88,
        Stationj = 89,
        Stationk = 90,
        CarWash = 91,
        UnitedLibertyPaper = 92,
        Boss = 93,
        Base = 94
    }

    /// <summary>
    /// The bodyparts of an player
    /// </summary>
    public enum Bodyparts : int {
        Head = 0,
        UpperBody = 1,
        LowerBody = 2,
        Special1 = 3,
        Hand = 4,
        Feet = 5,
        Jacket = 6,
        Hair = 7,
        Special2 = 8,
        Face = 10
    }

    /// <summary>
    /// The Weapons
    /// </summary>
    public enum Weapons : int {
        BaseballBat = 1,
        PoolCue = 2,
        Knife = 3,
        Grenade = 4,
        Molotov = 5,
        Glock = 7,
        DesertEagle = 9,
        PumpShotgun = 10,
        CombatShutgon = 11,
        MicroUzi = 12,
        Mp10 = 13,
        Ak47 = 14,
        M4 = 15,
        PSG1 = 16,
        Remington700 = 17,
        RPG7 = 18
    }

    /// <summary>
    /// There are various state types.
    /// </summary>
    public enum StateTypes : int {
        Disconnect = 0,
        Connect = 1,
        Spawn = 2,
        Death = 3,
        OnFoot = 4,
        EnterCar = 5,
        InVehicle = 6,
        Passenger = 7,
        ExitVehicle = 8,
        EnterVehicle = 9
    }

    /// <summary>
    /// The possible models for pickups
    /// </summary>
    public enum PickupModels : uint {
        HealthKit = 0x3fc62578,
        Armour = 0x972daa10,
        BaseballBat = 0x68d19067,
        PoolCue = 0x4e746e14,
        Knife = 0x3dfebd8b,
        Grenade = 0x3b373591,
        Molotov = 0x88b44609,
        RPG = 0x5603b9ec,
        GlockPistol = 0xf44c839d,
        DesertEagle = 0x5caeb064,
        Shotgun = 0x6e10d6c3,
        Beretta = 0xddb2b5ad,
        Uzi = 0xafd2e07b,
        Mp5 = 0x65daddfd,
        Ak47 = 0x1bdd0543,
        M4 = 0x35855559,
        Rifle = 0x08762932,
        M40A1 = 0x22c755b0
    }

    /// <summary>
    /// The types of pickups
    /// </summary>
    public enum PickupTypes : byte {
        /// <summary>
        /// Can't pickup, does not disappear
        /// </summary>
        CantPickup = 1,

        /// <summary>
        /// Can pickup, disappears on pickup
        /// </summary>
        CanPickup = 2
    }

    /// <summary>
    /// The Types of Checkpoints
    /// </summary>
    public enum CheckpointTypes : int {
        /// <summary>
        /// Cylinder (tube) with an arrow
        /// </summary>
        ArrowTube = 2,

        /// <summary>
        /// Cylinder (tube) with a flag
        /// </summary>
        FlagTube = 3,

        /// <summary>
        /// Corona with an arrow
        /// </summary>
        ArrowCorona = 4,

        /// <summary>
        /// Corona with a flag
        /// </summary>
        FlagCorona = 5,

        /// <summary>
        /// Just an arrow
        /// </summary>
        Arrow = 6,

        /// <summary>
        /// Just a flag
        /// </summary>
        Corona = 7,

        /// <summary>
        /// Just a circle
        /// </summary>
        Circle = 8
    }

    /// <summary>
    /// 3D Vector
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CVector3 {
        /// <summary>
        /// X Coordinate
        /// </summary>
        [System.ComponentModel.DefaultValue(0f)]
        public Single X { get; set; }

        /// <summary>
        /// Y Coordinate
        /// </summary>
        [System.ComponentModel.DefaultValue(0f)]
        public Single Y { get; set; }

        /// <summary>
        /// Z Coordinate
        /// </summary>
        [System.ComponentModel.DefaultValue(0f)]
        public Single Z { get; set; }
    }

    /// <summary>
    /// COntrol State
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CControlState {
        /// <summary>
        /// Left FootMove
        /// </summary>
        byte ucOnFootMove_left;

        /// <summary>
        /// Right Footmove
        /// </summary>
        byte ucOnFootMove_right;

        /// <summary>
        /// Upper Footmove
        /// </summary>
        byte ucOnFootMove_up;

        /// <summary>
        /// Down Footmove
        /// </summary>
        byte ucOnFootMove_down;

        /// <summary>
        /// VehicleMove Left
        /// </summary>
        byte ucInVehicleMove_left;

        /// <summary>
        /// VehicleMove Right
        /// </summary>
        byte ucInVehicleMove_right;

        /// <summary>
        /// VehicleMove Up
        /// </summary>
        byte ucInVehicleMove_up;

        /// <summary>
        /// VehicleMove Down
        /// </summary>
        byte ucInVehicleMove_down;

        /// <summary>
        /// VehicleTriggers Left
        /// </summary>
        byte ucInVehicleTriggers_left;

        /// <summary>
        /// VehicleTriggers Right
        /// </summary>
        byte ucInVehicleTriggers_right;

        /// <summary>
        /// Binary Key Count
        /// </summary>
        public enum AnonymousEnum {
            KEY_COUNT = 16
        }

        /// <summary>
        /// Binary Keys
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct Keys {
            // On Foot/In Vehicle
            /// <summary>
            /// Enter Vehicle Key
            /// </summary>
            public bool bEnterExitVehicle;

            // On Foot
            /// <summary>
            /// Sprint Key
            /// </summary>
            public bool bSprint;

            /// <summary>
            /// Jump Key
            /// </summary>
            public bool bJump;

            /// <summary>
            /// Attack Key
            /// </summary>
            public bool bAttack;

            /// <summary>
            /// Attack2 Key
            /// </summary>
            public bool bAttack2;

            /// <summary>
            /// Aimkey
            /// </summary>
            public bool bAim;

            /// <summary>
            /// FreeAim Key (?)
            /// </summary>
            public bool bFreeAim;

            /// <summary>
            /// MeleeAttack1 Key
            /// </summary>
            public bool bMeleeAttack1;

            /// <summary>
            /// MeleeAttack2 Key
            /// </summary>
            public bool bMeleeAttack2;

            /// <summary>
            /// MeleeKick Key
            /// </summary>
            public bool bMeleeKick;

            /// <summary>
            /// MeleeBlock Key
            /// </summary>
            public bool bMeleeBlock;

            // In Vehicle
            /// <summary>
            /// Handbrake Key
            /// </summary>
            public bool bHandbrake;

            /// <summary>
            /// Alternative Handbrake Key
            /// </summary>
            public bool bHandbrake2;

            /// <summary>
            /// Horn Key
            /// </summary>
            public bool bHorn;

            /// <summary>
            /// Driveby Key
            /// </summary>
            public bool bDriveBy;

            /// <summary>
            /// Helifire Key
            /// </summary>
            public bool bHeliPrimaryFire;
        }

        /// <summary>
        /// Keystate Infos
        /// </summary>
        public Keys keys;

        /// <summary>
        /// Is in combat?
        /// </summary>
        /// <returns>true if in combat otherwise false</returns>
        public bool IsInCombat() {
            return (keys.bMeleeAttack1 || keys.bMeleeAttack2 || keys.bMeleeKick || keys.bMeleeBlock);
        }

        /// <summary>
        /// Is firing?
        /// </summary>
        /// <returns>true if is firing otherwise false</returns>
        public bool IsFiring() {
            return (keys.bAttack);
        }

        /// <summary>
        /// Is aiming?
        /// </summary>
        /// <returns>true if is aiming otherwise false</returns>
        public bool IsAiming() {
            return (keys.bAttack2 || keys.bAim || keys.bFreeAim);
        }

        /// <summary>
        /// Is doing driveby?
        /// </summary>
        /// <returns>true if is doing driveby otherwise false</returns>
        public bool IsDoingDriveBy() {
            return (keys.bDriveBy);
        }

        /// <summary>
        /// Is firing with helicopter
        /// </summary>
        /// <returns>true if is firing with helicoper otherwise false</returns>
        public bool IsFiringHelicoptor() {
            return (keys.bHeliPrimaryFire);
        }

        /// <summary>
        /// Is sprinting?
        /// </summary>
        /// <returns>true if is sprinting otherwise false</returns>
        public bool IsSprinting() {
            return (keys.bSprint);
        }

        /// <summary>
        /// Using Horn?
        /// </summary>
        /// <returns>true if using otherwise false</returns>
        public bool IsUsingHorn() {
            return (keys.bHorn);
        }

        /// <summary>
        /// Is Jumping?
        /// </summary>
        /// <returns>true if jumping otherwise false</returns>
        public bool IsJumping() {
            return (keys.bJump);
        }

        /// <summary>
        /// Using Handbrake?
        /// </summary>
        /// <returns>true is using, otherwise false</returns>
        public bool IsUsingHandbrake() {
            return (keys.bHandbrake || keys.bHandbrake2);
        }

        /// <summary>
        /// Is using enter/exit @ Vehicle
        /// </summary>
        /// <returns>true if is using otherwise false</returns>
        public bool IsUsingEnterExitVehicle() {
            return (keys.bEnterExitVehicle);
        }
    }
}
