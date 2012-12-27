using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace IvmpDotNet {
    public class IvmpDotNetCore {
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

        #endregion

        #region Methods

        public bool InitModule(out string moduleName) {
            moduleName = ModuleName;

            Console.WriteLine("[{0}] InitModule", ModuleName);
            //string name = Imports.Server.Server_GetWeaponName(5);
            //Imports.Server.Server_Log("YOU CHANGED THE WAY! - " + name);

            ushort id = (ushort)Imports.Vehicles.Vehicles_Create(40, new Imports.CVector3() { X = 1657.118408f, Y = 421.462982f, Z = 28.569500f }, new Imports.CVector3() { X = 359.828613f, Y = 352.884033f, Z = 267.583008f }, 0, 0, 0, 0, -1);
            Console.WriteLine("VehicleID: {0}", id);

            Imports.CVector3 coords = Imports.Vehicles.Vehicles_GetCoordinates(id);
            Console.WriteLine("{0} - {1} - {2}", coords.X, coords.Y, coords.Z);

            Imports.Vehicles.Vehicles_SetLocked(id, 1);

            EventManager.PlayerSpawn += (o, e) => {
                e.Player.GiveWeapon(11, 1337);
            };

            Imports.Server.Server_Log("asdf");

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
    }
}
