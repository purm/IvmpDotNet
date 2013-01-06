using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Describes an Actor
    /// </summary>
    public interface IActor {
        #region Properties

        /// <summary>
        /// Gets or sets the actor's id
        /// </summary>
        ushort ActorId { get; set; }

        /// <summary>
        /// Checks if the actor is valid
        /// </summary>
        bool IsValid { get; }

        /// <summary>
        /// Gets or sets the actor's coordinates
        /// </summary>
        CVector3 Coordinates { set; get; }

        /// <summary>
        /// Gets or sets the actor's heading
        /// </summary>
        Single Heading { set; get; }

        /// <summary>
        /// Gets the actor's model
        /// </summary>
        PedModels Model { get; }

        /// <summary>
        /// Gets or sets the actor's name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Sets the nametag state of the selected actor.
        /// </summary>
        bool Nametag { set; }

        /// <summary>
        /// Toggle the actor's blip
        /// </summary>
        bool Blip { set; }

        /// <summary>
        /// Gets or sets the actor's color
        /// </summary>
        int Color { get; set; }

        /// <summary>
        /// Sets the frozen state of the selected actor.
        /// </summary>
        bool Frozen { set; }

        /// <summary>
        /// Adds or removes the helmet of the selected actor.
        /// </summary>
        bool Helmet { set; }

        #endregion

        #region Methods

        /// <summary>
        /// Removes the selected actor from any vehicle.
        /// </summary>
        /// <returns>True if the actor was removed successfully, otherwise false</returns>
        bool RemoveFromVehicle();

        /// <summary>
        /// Warps the actor into a vehicle
        /// </summary>
        /// <param name="vehicle">The vehicle to warp in</param>
        /// <param name="seatid">The seat the actor will sit on [0 for driver]</param>
        /// <returns>True if the actor was warped successfully, otherwise false</returns>
        bool WarpIntoVehicle(IVehicle vehicle, Int32 seatid);

        /// <summary>
        /// Deletes the actor
        /// </summary>
        /// <returns>True if the actor was successfully deleted, otherwise false</returns>
        bool Delete();

        /// <summary>
        /// Lets the actor walk to a certain position. Please note that this is not synced, which means you might sync its position with setActorCoordinates afterwards.
        /// </summary>
        /// <param name="player">the player whose actor should move</param>
        /// <param name="vecPosition">the position</param>
        /// <param name="iType">??</param>
        /// <returns>True if the action succeded</returns>
        bool WalkToCoordinatesForPlayer(IPlayer player, CVector3 vecPosition, Int32 iType);

        /// <summary>
        /// Let the actor drive to a certain position.
        /// </summary>
        /// <param name="vecDriveTo">The position to drive to</param>
        /// <param name="vecDriveRot">The rotation to move in</param>
        /// <param name="bStop">??</param>
        /// <returns>True if the action succeded</returns>
        bool DriveToCoordinates(CVector3 vecDriveTo, CVector3 vecDriveRot, Boolean bStop);

        /// <summary>
        /// Sets the animation of the selected actor.
        /// </summary>
        /// <param name="szGroup">the group of the animation</param>
        /// <param name="szAnim">the name of the animation</param>
        /// <returns></returns>
        bool ForceAnim(String szGroup, String szAnim);

        #endregion
    }
}
