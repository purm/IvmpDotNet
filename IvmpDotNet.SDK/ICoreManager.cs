using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Manages all the managers :D
    /// </summary>
    public interface ICoreManager {
        #region Properties

        /// <summary>
        /// Manages all the events
        /// </summary>
        IEvents EventManager { get; }

        /// <summary>
        /// Manages all the players
        /// </summary>
        IPlayerManager PlayerManager { get; }

        /// <summary>
        /// Manages the server
        /// </summary>
        IServerManager ServerManager { get; }

        /// <summary>
        /// Manages all the actors
        /// </summary>
        IActorManager ActorManager { get; }

        /// <summary>
        /// Manages all the blips
        /// </summary>
        IBlipManager BlipManager { get; }

        /// <summary>
        /// Manages all the checkpoints
        /// </summary>
        ICheckPointManager CheckpointManager { get; }

        /// <summary>
        /// Manages all the vehicles
        /// </summary>
        IVehicleManager VehicleManager { get; }

        /// <summary>
        /// Manages all the scripts
        /// </summary>
        IScriptManager ScriptManager { get; }

        /// <summary>
        /// Manages the area
        /// </summary>
        IAreaManager AreaManager { get; }

        /// <summary>
        /// manages all the objects
        /// </summary>
        IObjectManager ObjectManager { get; }

        /// <summary>
        /// Manages all the pickups
        /// </summary>
        IPickupManager PickupManager { get; }

        /// <summary>
        /// Manages hashing
        /// </summary>
        IHashManager HashManager { get; }

        /// <summary>
        /// Manages the world
        /// </summary>
        IWorldManager WorldManager { get; }

        /// <summary>
        /// Manages the network
        /// </summary>
        INetworkManager NetworkManager { get; }

        #endregion
    }
}
