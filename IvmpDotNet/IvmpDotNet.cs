using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace IvmpDotNet {
    public class IvmpDotNet {
        public static readonly string ModuleName = "CLR Host";

        private static object _singletonMutex = new object();
        private static IvmpDotNet _singleton;
        public static IvmpDotNet Singleton {
            get {
                lock (_singletonMutex) {
                    if (_singleton == null)
                        _singleton = new IvmpDotNet();

                    return _singleton;
                }
            }
        }

        public bool InitModule(out string moduleName) {
            moduleName = ModuleName;

            Console.WriteLine("[{0}] InitModule", ModuleName);
            //string name = Imports.Server.Server_GetWeaponName(5);
            //Imports.Server.Server_Log("YOU CHANGED THE WAY! - " + name);

            ushort id = (ushort)Imports.Vehicles.Vehicles_Create(40, new Imports.CVector3() { fX = 1657.118408f, fY = 421.462982f, fZ = 28.569500f }, new Imports.CVector3() { fX = 359.828613f, fY = 352.884033f, fZ = 267.583008f }, 0, 0, 0, 0, -1);
            Console.WriteLine("VehicleID: {0}", id);

            Imports.CVector3 coords = Imports.Vehicles.Vehicles_GetCoordinates(id);
            Console.WriteLine("{0} - {1} - {2}", coords.fX, coords.fY, coords.fZ);

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
    }
}
