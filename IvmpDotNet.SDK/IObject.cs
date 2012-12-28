using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Represents a fire
    /// </summary>
    public interface IFire {
        #region Properties

        /// <summary>
        /// Gets or sets the fire id
        /// </summary>
        ushort FireId { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Deletes the fire
        /// </summary>
        void Delete();

        #endregion
    }

    /// <summary>
    /// Represents an objects
    /// </summary>
    public interface IObject {
        #region Properties

        /// <summary>
        /// Gets or sets the object id
        /// </summary>
        ushort ObjectId { get; set; }

        /// <summary>
        /// Gets the object's model
        /// </summary>
        int Model { get; }

        /// <summary>
        /// Gets or sets the object's coordinates
        /// </summary>
        CVector3 Coordinates { get; set; }

        /// <summary>
        /// Gets or sets the object's rotation
        /// </summary>
        CVector3 Rotation { get; set; }

        /// <summary>
        /// Gets or sets the object's dimension
        /// </summary>
        byte Dimension { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Attaches the object to a player
        /// </summary>
        /// <param name="player">the player you want to attach the object to</param>
        /// <param name="vecPos">the offset value</param>
        /// <param name="vecRot">the rotation value</param>
        /// <param name="iBone">The player's bone to attach to</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool AttachToPlayer(IPlayer player, CVector3 vecPos, CVector3 vecRot, Int32 iBone);

        /// <summary>
        /// Rotates the object
        /// </summary>
        /// <param name="vecRotation">Target rotation</param>
        /// <param name="fSpeed">Speed for rotation</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool Rotate(CVector3 vecRotation, Single fSpeed);

        /// <summary>
        /// Moves an object
        /// </summary>
        /// <param name="vecMoveTarget">Target position</param>
        /// <param name="vecMoveRot">Target rotation</param>
        /// <param name="fSpeed">Speed for moving</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool Move(CVector3 vecMoveTarget, CVector3 vecMoveRot, Single fSpeed);

        /// <summary>
        /// This function attaches an object to the selected vehicle.
        /// </summary>
        /// <param name="vehicle">the vehicle you want to attach the object to</param>
        /// <param name="vecPos">the offset value</param>
        /// <param name="vecRot">the rotation value</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool AttachVehicle(IVehicle vehicle, CVector3 vecPos, CVector3 vecRot);

        /// <summary>
        /// Attachs the object to a ped
        /// </summary>
        /// <param name="pedId">the id of the ped</param>
        /// <param name="vecPos">offset</param>
        /// <param name="vecRot">rotation</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool AttachPed(ushort pedId, CVector3 vecPos, CVector3 vecRot);

        /// <summary>
        /// Deletes the object
        /// </summary>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool Delete();

        #endregion
    }
}
