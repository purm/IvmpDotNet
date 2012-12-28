using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Manages networking
    /// </summary>
    public interface INetworkManager {
        /// <summary>
        /// Bans an ip
        /// </summary>
        /// <param name="strIp">the player who to ban</param>
        /// <param name="uiSeconds">how long to ban the player for (seconds)</param>
        /// <returns>Returns true if the player has been banned, false otherwise.</returns>
        bool AddBan(String strIp, uint uiSeconds);
    }
}
