using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    public enum LockedState {
        Unlocked = 0,
        Locked = 1,
        LockedWithBreakableGlass = 2
    }

    public interface IVehicle {
        ushort VehicleId { get; set; }

        CVector3 Coordinates { get; set; }
        CVector3 Rotation { set; get; }
        Single DirtLevel { get; set; }
        bool SirenState { get; set; }
        bool IsValid { get; }
        int[] Colors { get; set; }
        int Model { get; }
        int Health { get; set; }
        CVector3 Velocty { get; set; }
        CVector3 AngularVelocity { get; set; }
        bool IsOccupied { get; }
        IPlayer[] Occupants { get; }
        LockedState Locked { get; set; }
        int Variation { get; set; }
        bool EngineStatus { get; set; }
        bool Lights { get; set; }
        bool TaxiLights { get; set; }
        int Dimension { get; set; }
        int RespawnDelay { get; set; }
        
        Boolean Delete();

        
        Boolean SoundHorn(Int32 iDuration);    
        Boolean Respawn();   
        Boolean SetIndicators(Boolean bFrontLeft, Boolean bFrontRight, Boolean bBackLeft, Boolean bBackRight); 
        //IntPtr GetIndicators(); //*TODO* 
      //  Boolean SetComponent(Int32 iSlot, Boolean bOn);
        Boolean ResetComponents();
        //IntPtr GetComponents();      
        Boolean ControlCarDoors(Int32 door, Boolean door2, Single door3);
        Boolean RepairWheels();
        Boolean RepairWindows();
        Boolean Repair();
    }
}
