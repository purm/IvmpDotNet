using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SampleCLRModule {
    public class ExampleModule : IModule {
        System.Timers.Timer timer;
        List<IvmpDotNet.SDK.IVehicle> vehicles;
        ICoreManager coreManager;

        void EventManager_PlayerCommand(object sender, SDK.PlayerCommandArgs e) {
            foreach (string cmd in e.Command) {
                e.Player.SendMessage("ASDF: " + cmd, 0, false);
            }

            if (e.Command[0] == "/asdf") {
                e.Player.SendMessage("You entered valid message", 0, false);
                e.Player.GiveWeapon(Weapons.DesertEagle, 1337);
            } else if (e.Command[0] == "/test") {
                var obj = coreManager.ObjectManager.Create(2627789200, e.Player.Coordinates, new SDK.CVector3());
                obj.AttachToPlayer(e.Player, new CVector3(), new SDK.CVector3(), -1);
            } else {
                e.Player.SendMessage("You entered Invalid Message", 0, false);
            }
        }

        void EventManager_PlayerSpawn(object sender, SDK.PlayerEventArgs e) {
            e.Player.GiveWeapon(Weapons.M4, 1337);
            e.Player.GiveHelmet();
            e.Player.Money = 1337;
            e.Player.DisplayText(100, 100, "asdff", 60 * 1000);
        }

        public void Load(ICoreManager mgr) {
            coreManager = mgr;

            coreManager.EventManager.PlayerSpawn += EventManager_PlayerSpawn;
            coreManager.EventManager.PlayerCommand += EventManager_PlayerCommand;

            vehicles = new List<IVehicle>() {
                coreManager.VehicleManager.Create(
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
                    0, 0, 0, 0, -1),
                coreManager.VehicleManager.Create(
                    17,
                    new SDK.CVector3() {
                        X = 1657.118408f,
                        Y = 421.462982f,
                        Z = 128.569500f
                    },
                    new SDK.CVector3() {
                        X = 359.828613f,
                        Y = 352.884033f,
                        Z = 267.583008f
                    },
                    0, 0, 0, 0, -1)
            };

            timer = new System.Timers.Timer();
            timer.Interval = TimeSpan.FromSeconds(10).TotalMilliseconds;
            timer.Elapsed += timer_Elapsed;
            timer.Start();

            Console.WriteLine("Loaded Sample CLR Module");
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e) {
            coreManager.PlayerManager.SendMessageToAll("SPAAAM", 0, false);
        }


        public void Unload() {
            timer.Elapsed -= timer_Elapsed;
            coreManager.EventManager.PlayerSpawn -= EventManager_PlayerSpawn;
            coreManager.EventManager.PlayerCommand -= EventManager_PlayerCommand;

            foreach (var vehicle in vehicles)
                vehicle.Delete();
        }
    }
}
