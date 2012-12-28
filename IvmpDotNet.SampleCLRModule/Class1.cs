using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvmpDotNet.SDK;

namespace IvmpDotNet.SampleCLRModule {
    public static class Class1 {
        static IvmpDotNet.SDK.IVehicle vehicle;
        static ICoreManager coreManager;

        public static void LoadCLRModule(IvmpDotNet.SDK.ICoreManager mgr) {
            coreManager = mgr;

            coreManager.EventManager.PlayerSpawn += EventManager_PlayerSpawn;
            coreManager.EventManager.PlayerCommand += EventManager_PlayerCommand;

            //coreManager.NetworkManager.AddBan("test", 123);

            vehicle = coreManager.VehicleManager.Create(
                40,
                new SDK.CVector3() {
                    X = 1657.118408f,
                    Y = 421.462982f,
                    Z = 28.569500f
                },
                new SDK.CVector3() {
                    X = 359.828613f,
                    Y = 352.884033f,
                    Z = 267.583008f
                },
                0, 0, 0, 0, -1);

            Console.WriteLine("ASDF: {0}", coreManager.ServerManager.GetWeaponName(10));
            Console.WriteLine("Loaded Sample CLR Module");
        }

        public static void UnloadCLRModule() {
            Console.WriteLine("Unloading Sample CLR Module");

            //TODO: Cleanup.. for example events:
            coreManager.EventManager.PlayerSpawn -= EventManager_PlayerSpawn;
            coreManager.EventManager.PlayerCommand -= EventManager_PlayerCommand;

            //and maybe destroy objects/vehicles
            vehicle.Delete();
        }

        static void EventManager_PlayerCommand(object sender, SDK.PlayerCommandArgs e) {
            foreach (string cmd in e.Command) {
                e.Player.SendMessage("ASDF: " + cmd, 0, false);
            }

            if (e.Command[0] == "/unload") {
                UnloadCLRModule();
            } else if (e.Command[0] == "/asdf") {
                e.Player.SendMessage("You entered valid message", 0, false);
                e.Player.GiveWeapon(18, 1337);
            } else if (e.Command[0] == "/test") {
                var obj = coreManager.ObjectManager.Create(2627789200, e.Player.Coordinates, new SDK.CVector3());
                obj.AttachToPlayer(e.Player, e.Player.Coordinates, new SDK.CVector3(), -1);
            } else {
                e.Player.SendMessage("You entered Invalid Message", 0, false);
            }
        }

        static void EventManager_PlayerSpawn(object sender, SDK.PlayerEventArgs e) {
            e.Player.GiveWeapon(10, 1337);
            e.Player.GiveHelmet();
            e.Player.Money = 1337;
            e.Player.DisplayText(100, 100, "asdff", 60 * 1000);
        }
    }
}
