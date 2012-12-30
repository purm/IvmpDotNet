using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Manages the players
    /// </summary>
    public interface IPlayerManager {
        #region Methods

        /// <summary>
        /// Sends a message to all the players
        /// </summary>
        /// <param name="szMessage">message text</param>
        /// <param name="iColor">message color</param>
        /// <param name="sqbAllowFormatting">message formatting allowed?</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool SendMessageToAll(String szMessage, Int32 iColor, Boolean sqbAllowFormatting);

        /// <summary>
        /// Displays a text for all the players
        /// </summary>
        /// <param name="fPosX">x pos of the text</param>
        /// <param name="fPosY">y pos of the text</param>
        /// <param name="szText">message to display</param>
        /// <param name="iTime">time in ms</param>
        /// <returns>Returns true if successful, false otherwise.</returns>
        bool DisplayTextForAll(Single fPosX, Single fPosY, String szText, Int32 iTime);

        /// <summary>
        /// Gets a player by its ID
        /// </summary>
        /// <param name="playerId">player id</param>
        /// <returns>the player with the specified id</returns>
        IPlayer GetAt(ushort playerId);

        /// <summary>
        /// Checks if a player with a specific id exists
        /// </summary>
        /// <param name="playerId">id to check</param>
        /// <returns>true if the player exists, otherwise false</returns>
        bool DoesExist(ushort playerId);

        /// <summary>
        /// adds a player
        /// </summary>
        /// <param name="playerId">id for the new player</param>
        /// <param name="sPlayerName">name of the new player</param>
        void Add(ushort playerId, String sPlayerName);

        /// <summary>
        /// Checks if a name is in use
        /// </summary>
        /// <param name="szNick">name to check</param>
        /// <returns>true if the name is already in usage</returns>
        bool IsNameInUse(String szNick);

        /// <summary>
        /// Gets a player by it's name
        /// </summary>
        /// <param name="sNick">name so search for</param>
        /// <returns>the player object</returns>
        IPlayer GetPlayerFromName(String sNick);

        #endregion
    }
}
