using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Manages vehicles
    /// </summary>
    public interface IVehicleManager {
        #region Methods

        /// <summary>
        /// Creates a vehicle
        /// </summary>
        /// <param name="iModelId">vehicle's model</param>
        /// <param name="vecPosition">position where to create</param>
        /// <param name="vecRotation">rotation</param>
        /// <param name="color1">first color</param>
        /// <param name="color2">second color</param>
        /// <param name="color3">third color</param>
        /// <param name="color4">fourth color</param>
        /// <param name="respawn_delay">respawn delay (-1 for instant respawn)</param>
        /// <returns>The vehicle's object</returns>
        IVehicle Create(Int32 iModelId, CVector3 vecPosition, CVector3 vecRotation, Int32 color1, Int32 color2, Int32 color3, Int32 color4, Int32 respawn_delay);

        /// <summary>
        /// Removes a vehicle by its id
        /// </summary>
        /// <param name="vehicleId">vehicle to remove</param>
        void Remove(ushort vehicleId);

        /// <summary>
        /// Checks if a vehicle exists by it's id
        /// </summary>
        /// <param name="vehicleId">id to check</param>
        /// <returns>true if it exist otherwise false</returns>
        bool DoesExist(ushort vehicleId);

        #endregion
    }
}
