using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Represents a blip on the radar
    /// </summary>
    public interface IBlip {
        #region Properties

        /// <summary>
        /// Gets or sets the blip's id
        /// </summary>
        ushort BlipId { get; set; }

        /// <summary>
        /// Gets or sets the blip's coordinates
        /// </summary>
        CVector3 Coordinates { get; set; }

        /// <summary>
        /// Gets the blip's color
        /// </summary>
        int Color { get; }

        /// <summary>
        /// Gets the blip's name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the blip's size
        /// </summary>
        Single Size { get; }

        #endregion

        #region Methods

        /// <summary>
        /// Sets the blip's color for a player
        /// </summary>
        /// <param name="color">Color</param>
        /// <param name="player">Player to set for</param>
        /// <returns>True if everything succeded, otherwise false</returns>
        bool SetColor(int color, IPlayer player);

        /// <summary>
        /// Sets the blip's name for a player
        /// </summary>
        /// <param name="szName">Name</param>
        /// <param name="player">Player to set for</param>
        /// <returns>True if everything succeded, otherwise false</returns>
        bool SetName(String szName, IPlayer player);

        /// <summary>
        /// Toggles if a route to the blip is shown for a player.
        /// </summary>
        /// <param name="bToggle">True to show, false to hide</param>
        /// <param name="player">Player to show/hide for</param>
        /// <returns>True if everything succeded</returns>
        bool ToggleRoute(Boolean bToggle, IPlayer player);

        /// <summary>
        /// Toggles if a blip is short range for a player.
        /// </summary>
        /// <param name="bToggle">toggle</param>
        /// <param name="player">The player to toggle for</param>
        /// <returns>True if everything succeded</returns>
        bool ToggleShortRange(Boolean bToggle, IPlayer player);

        /// <summary>
        /// Sets the blip's size for a player.
        /// </summary>
        /// <param name="fSize">Size for the blip</param>
        /// <param name="player">THe player to set the size for</param>
        /// <returns>True if everything succeded</returns>
        bool SetSize(Single fSize, IPlayer player);

        /// <summary>
        /// Deletes the blip
        /// </summary>
        /// <returns>True if deletion succeded</returns>
        bool Delete();

        #endregion
    }
}
