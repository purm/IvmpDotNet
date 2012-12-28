using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Represents a checkpoint
    /// </summary>
    public interface ICheckPoint {
        #region Properties

        /// <summary>
        /// Gets or sets the checkpoint's id
        /// </summary>
        ushort CheckPointId { get; set; }

        /// <summary>
        /// Gets or sets the checkpoint type
        /// </summary>
        CheckpointTypes Type { get; set; }

        /// <summary>
        /// Gets or sets the checkpoint position
        /// </summary>
        CVector3 Position { get; set; }

        /// <summary>
        /// Gets or sets the target position of the checkpoint
        /// </summary>
        CVector3 TargetPosition { get; set; }

        /// <summary>
        /// Gets or sets the checkpoint's radius
        /// </summary>
        Single Radius { get; set; }

        /// <summary>
        /// Gets or sets the checkpoint's dimension
        /// </summary>
        Byte Dimension { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Deletes the checkpoint
        /// </summary>
        /// <returns>True if the deletion succeded</returns>
        bool Delete();

        /// <summary>
        /// Shows the checkpoint for a player
        /// </summary>
        /// <param name="player">Player</param>
        /// <returns>True if everthing succeded otherwise false</returns>
        bool ShowForPlayer(IPlayer player);

        /// <summary>
        /// Hides the checkpoint for a player
        /// </summary>
        /// <param name="player">Player</param>
        /// <returns>True if everything succeded otherwise false</returns>
        bool HideForPlayer(IPlayer player);

        /// <summary>
        /// Shows the checkpoint for all players
        /// </summary>
        /// <returns>True if everthing succeded otherwise false</returns>
        bool ShowForAll();

        /// <summary>
        /// Hides the checkpoint for all players
        /// </summary>
        /// <returns>True if everthing succeded otherwise false</returns>
        bool HideForAll();

        #endregion
    }
}
