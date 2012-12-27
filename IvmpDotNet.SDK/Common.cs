using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// 3D Vector
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CVector3 {
        /// <summary>
        /// X Coordinate
        /// </summary>
        public Single X { get; set; }

        /// <summary>
        /// Y Coordinate
        /// </summary>
        public Single Y { get; set; }

        /// <summary>
        /// Z Coordinate
        /// </summary>
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
