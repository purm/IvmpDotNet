using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Represents a vehicle
    /// </summary>
    public interface IVehicle {
        #region Properties

        ushort VehicleId { get; set; }

        CVector3 Coordinates { get; set; }
        CVector3 Rotation { set; get; }
        Single DirtLevel { get; set; }
        bool SirenState { get; set; }
        bool IsValid { get; }
        int[] Colors { get; set; }
        VehicleModels Model { get; }
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

        #endregion

        #region Methods

        /// <summary>
        /// This function deletes a vehicle.
        /// </summary>
        /// <returns>true if the vehicle got deleted, false otherwise</returns>
        Boolean Delete();

        /// <summary>
        /// This function will sound the horn of the specified vehicle and will be audible to all players within rage of hearing it.<br/>
        /// WARNING: The effects of this function cannot be disabled if you set a large horn sounding period.
        /// </summary>
        /// <param name="iDuration">duration (Milliseconds)</param>
        /// <returns>true if the vehicles horn has been sound.</returns>
        Boolean SoundHorn(Int32 iDuration);

        /// <summary>
        /// Respawns the vehicle
        /// </summary>
        /// <returns>true if the vehicle was respawned</returns>
        Boolean Respawn();

        /// <summary>
        /// This function toggles a vehicles indicator status.
        /// </summary>
        /// <param name="bFrontLeft">toggle</param>
        /// <param name="bFrontRight">toggle</param>
        /// <param name="bBackLeft">toggle</param>
        /// <param name="bBackRight">toggle</param>
        /// <returns>Returns true if the indicator state was change.</returns>
        Boolean SetIndicators(Boolean bFrontLeft, Boolean bFrontRight, Boolean bBackLeft, Boolean bBackRight);

        /// <summary>
        /// Gets the indicator status of a chosen vehicle
        /// </summary>
        /// <returns>the indicator status (bool, bool, bool, bool in an array)</returns>
        bool[] GetIndicators();

        /// <summary>
        /// This function add component to a vehicle.
        /// </summary>
        /// <param name="iSlot">The component ID</param>
        /// <param name="bOn">Toggle for component visibility</param>
        /// <returns>Returns true when the component was added, false otherwise.</returns>
        Boolean SetComponent(Int32 iSlot, Boolean bOn);

        /// <summary>
        /// Resets all the vehicle's components
        /// </summary>
        /// <returns>Returns true if successful, false otherwise.</returns>
        Boolean ResetComponents();

        /// <summary>
        /// This function gets the vehicle's components.
        /// </summary>
        /// <returns>the vehicle's components</returns>
        bool[] GetComponents();

        /// <summary>
        /// This function allows you to control a vehicles doors.
        /// </summary>
        /// <param name="door">which door should be controlled</param>
        /// <param name="door2">state</param>
        /// <param name="door3">angle</param>
        /// <returns>true when the door was adjusted, false otherwise.</returns>
        Boolean ControlCarDoors(VehicleDoors door, Boolean door2, Single door3);

        /// <summary>
        /// Repairs the vehicle's wheels
        /// </summary>
        /// <returns>true if the wheels were repaired, false otherwise</returns>
        Boolean RepairWheels();

        /// <summary>
        /// Repairs the vehicle's windows
        /// </summary>
        /// <returns>true if the windows were repaired, false otherwise</returns>
        Boolean RepairWindows();

        /// <summary>
        /// Repairs the whole vehicle
        /// </summary>
        /// <returns>true if it was repaired, false otherwise</returns>
        Boolean Repair();

        #endregion
    }
}
