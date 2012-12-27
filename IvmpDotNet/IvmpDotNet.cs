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

        public EventManager EventHandler {
            get {
                return _eventManager;
            }
        }

        private EventManager _eventManager = new EventManager();
        private PlayerManager _playerManager = new PlayerManager();
        private ServerManager _serverManager = new ServerManager();
        private ActorManager _actorManager = new ActorManager();
        private BlipManager _blipManager = new BlipManager();
        private CheckPointManager _checkpointManager = new CheckPointManager();
        private VehicleManager _vehicleManager = new VehicleManager();
        private ScriptManager _scriptManager = new ScriptManager();
        private AreaManager _areaManager = new AreaManager();
        private ObjectManager _objectManager = new ObjectManager();
        private PickupManager _pickupManager = new PickupManager();
        private HashManager _hashManager = new HashManager();
        private WorldManager _worldManager = new WorldManager();
        private NetworkManager _networkManager = new NetworkManager();

        #endregion

        #region Methods

        public bool InitModule(out string moduleName) {
            moduleName = ModuleName;

            //Console.WriteLine("[{0}] InitModule", ModuleName);
            _serverManager.Log("Initializing {0}", ModuleName);

            //Loading all the CLR Modules
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
            //Console.WriteLine("[{0}] SetupFunctions", ModuleName);
        }

        public void SetupInterfaces() {
            //Console.WriteLine("[{0}] SetupInterfaces", ModuleName);
        }

        public void SetupNewInterfaces() {
            //Console.WriteLine("[{0}] SetupNewInterfaces", ModuleName);
        }

        #endregion

        public SDK.IEvents EventManager {
            get { return this._eventManager; }
        }

        public SDK.IPlayerManager PlayerManager {
            get { return _playerManager; }
        }


        public SDK.IServerManager ServerManager {
            get { return _serverManager; }
        }


        public SDK.IActorManager ActorManager {
            get { return _actorManager; }
        }

        public SDK.IBlipManager BlipManager {
            get { return _blipManager; }
        }


        public SDK.ICheckPointManager CheckpointManager {
            get { return _checkpointManager; }
        }

        public SDK.IVehicleManager VehicleManager {
            get { return _vehicleManager; }
        }


        public SDK.IScriptManager ScriptManager {
            get { return _scriptManager; }
        }

        public SDK.IAreaManager AreaManager {
            get { return _areaManager; }
        }


        public SDK.IObjectManager ObjectManager {
            get { return _objectManager; }
        }


        public SDK.IPickupManager PickupManager {
            get { return _pickupManager; }
        }


        public SDK.IHashManager HashManager {
            get { return _hashManager; }
        }


        public SDK.IWorldManager WorldManager {
            get { return _worldManager; }
        }


        public SDK.INetworkManager NetworkManager {
            get { return _networkManager; }
        }
    }
}
