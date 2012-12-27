using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    public interface ICoreManager {
        IEvents EventManager { get; }
        IPlayerManager PlayerManager { get; }
        IServerManager ServerManager { get; }
        IActorManager ActorManager { get; }
        IBlipManager BlipManager { get; }
        ICheckPointManager CheckpointManager { get; }
        IVehicleManager VehicleManager { get; }
        IScriptManager ScriptManager { get; }
        IAreaManager AreaManager { get; }
    }
}
