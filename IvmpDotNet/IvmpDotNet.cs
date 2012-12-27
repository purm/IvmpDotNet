using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using IvmpDotNet.Wrappings;

namespace IvmpDotNet {
    public class IvmpDotNetCore : IvmpDotNet.SDK.ICoreManager {
        #region Constants

        public static readonly string ModuleName = "CLR Host";

        #endregion

        #region Properties

        private static object _singletonMutex = new object();
        private static IvmpDotNetCore _singleton;
        public static IvmpDotNetCore Singleton {
            get {
                lock (_singletonMutex) {
                    if (_singleton == null)
                        _singleton = new IvmpDotNetCore();

                    return _singleton;
                }
            }
        }

        private EventManager _eventManager = new EventManager();
        public EventManager EventManager {
            get { return _eventManager; }
        }

        private PlayerManager _playerManager = new PlayerManager();
        private ServerManager _serverManager = new ServerManager();
        private ActorManager _actorManager = new ActorManager();
        private BlipManager _blipManager = new BlipManager();
        private CheckPointManager _checkpointManager = new CheckPointManager();
        private VehicleManager _vehicleManager = new VehicleManager();
        private ScriptManager _scriptManager = new ScriptManager();
        private AreaManager _areaManager = new AreaManager();

        #endregion

        #region Methods

        public bool InitModule(out string moduleName) {
            moduleName = ModuleName;

            Console.WriteLine("[{0}] InitModule", ModuleName);

            CLRModuleLoader.LoadModules(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "CLRModules"));

            return true;
        }

        public void ScriptLoad() {
            //Console.WriteLine("[{0}] ScriptLoad", ModuleName);
        }

        public void Pulse() {
            //Console.WriteLine("[{0}] Pulse", ModuleName);
        }

        public void SetupFunctions() {
            Console.WriteLine("[{0}] SetupFunctions", ModuleName);
        }

        public void SetupInterfaces() {
            Console.WriteLine("[{0}] SetupInterfaces", ModuleName);
        }

        public void SetupNewInterfaces() {
            Console.WriteLine("[{0}] SetupNewInterfaces", ModuleName);
        }

        #endregion

        SDK.IEvents SDK.ICoreManager.EventManager {
            get { return this._eventManager; }
        }

        SDK.IPlayerManager SDK.ICoreManager.PlayerManager {
            get { return _playerManager; }
        }


        SDK.IServerManager SDK.ICoreManager.ServerManager {
            get { return _serverManager; }
        }


        SDK.IActorManager SDK.ICoreManager.ActorManager {
            get { return _actorManager; }
        }

        SDK.IBlipManager SDK.ICoreManager.BlipManager {
            get { return _blipManager; }
        }


        SDK.ICheckPointManager SDK.ICoreManager.CheckpointManager {
            get { return _checkpointManager; }
        }

        SDK.IVehicleManager SDK.ICoreManager.VehicleManager {
            get { return _vehicleManager; }
        }


        SDK.IScriptManager SDK.ICoreManager.ScriptManager {
            get { return _scriptManager; }
        }

        SDK.IAreaManager SDK.ICoreManager.AreaManager {
            get { return _areaManager; }
        }
    }
}
