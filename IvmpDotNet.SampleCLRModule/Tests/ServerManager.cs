using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SampleCLRModule.Tests {
    public class ServerManager : IModule {
        IServerManager serverManager;

        public void Load(ICoreManager coreManager) {
            serverManager = coreManager.ServerManager;

            serverManager.AddRule("Gamemode", "Deathmath");
            Debug.Assert(serverManager.GetRule("Gamemode") == "Deathmath");
            Debug.Assert(serverManager.ForceWind(123f));
            Debug.Assert(serverManager.GetVehicleName(VehicleModels.Predator) == "Predator");
        }

        public void Unload() {
            serverManager = null;
        }
    }
}
