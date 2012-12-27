using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    [StructLayout(LayoutKind.Sequential)]
    public struct CVector3 {
        public Single X { get; set; }
        public Single Y { get; set; }
        public Single Z { get; set; }
    }

    public enum VehicleLocking {
        Unlocked = 0,
        Locked = 1,
        LockedWithBreakableGlass = 2
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CControlState {
        byte ucOnFootMove_left;
        byte ucOnFootMove_right;
        byte ucOnFootMove_up;
        byte ucOnFootMove_down;

        byte ucInVehicleMove_left;
        byte ucInVehicleMove_right;
        byte ucInVehicleMove_up;
        byte ucInVehicleMove_down;

        byte ucInVehicleTriggers_left;
        byte ucInVehicleTriggers_right;

        // Binary Key Count
        public enum AnonymousEnum {
            KEY_COUNT = 16
        }

        // Binary Keys
        [StructLayout(LayoutKind.Sequential)]
        public struct Keys {
            // On Foot/In Vehicle
            public bool bEnterExitVehicle;

            // On Foot
            public bool bSprint;
            public bool bJump;
            public bool bAttack;
            public bool bAttack2;
            public bool bAim;
            public bool bFreeAim;
            public bool bMeleeAttack1;
            public bool bMeleeAttack2;
            public bool bMeleeKick;
            public bool bMeleeBlock;

            // In Vehicle
            public bool bHandbrake;
            public bool bHandbrake2;
            public bool bHorn;
            public bool bDriveBy;
            public bool bHeliPrimaryFire;
        }

        public Keys keys;

        public bool IsInCombat() {
            return (keys.bMeleeAttack1 || keys.bMeleeAttack2 || keys.bMeleeKick || keys.bMeleeBlock);
        }

        public bool IsFiring() {
            return (keys.bAttack);
        }

        public bool IsAiming() {
            return (keys.bAttack2 || keys.bAim || keys.bFreeAim);
        }

        public bool IsDoingDriveBy() {
            return (keys.bDriveBy);
        }

        public bool IsFiringHelicoptor() {
            return (keys.bHeliPrimaryFire);
        }

        public bool IsSprinting() {
            return (keys.bSprint);
        }

        public bool IsUsingHorn() {
            return (keys.bHorn);
        }

        public bool IsJumping() {
            return (keys.bJump);
        }

        public bool IsUsingHandbrake() {
            return (keys.bHandbrake || keys.bHandbrake2);
        }

        public bool IsUsingEnterExitVehicle() {
            return (keys.bEnterExitVehicle);
        }
    }
}
