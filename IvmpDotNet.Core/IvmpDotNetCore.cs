using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using IvmpDotNet.Wrappings;

namespace IvmpDotNet.Core {
    public class IvmpDotNetCore : IvmpDotNet.SDK.ICoreManager {
        #region Constants

        public static readonly string ModulePath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "CLRModules");
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
        public CLRModuleLoader ModuleLoader = new CLRModuleLoader();

        #region Managers

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

        #endregion

        #endregion

        #region Methods

        public bool InitModule(out string moduleName) {
            moduleName = ModuleName;

            //Console.WriteLine("[{0}] InitModule", ModuleName);
            Log("[Initializing...");

            //Loading all the CLR Modules
            ModuleLoader.LoadModules(ModulePath);

            EventManager.ConsoleInput += EventManager_ConsoleInput;

            return true;
        }

        void EventManager_ConsoleInput(object sender, SDK.ConsoleEventArgs e) {
            ExecuteTextCommand(e.Text);
        }

        public void Log(string message, params object[] args) {
            Singleton.ServerManager.Log(string.Format("[CLR Host] {0}", string.Format(message, args)));
        }

        private void ExecuteTextCommand(string command) {
            string[] args = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            if (args.Length < 1)
                return;

            if (args[0] != "clr")
                return;

            if (args.Length < 2) {
                Log("Possible commands:");
                Log("\tclr load (loads all clr modules)");
                Log("\tclr unload (unloads all clr modules)");
                Log("\tclr reload (reloads all clr modules)");
                return;
            }

            switch (args[1]) {
                case "load":
                    ModuleLoader.LoadModules(ModulePath);
                    break;
                case "unload":
                    ModuleLoader.UnloadModules();
                    break;
                case "reload":
                    ModuleLoader.ReloadModules();
                    break;
                default:
                    Log("unkwon command");
                    break;
            }
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
    }
}
