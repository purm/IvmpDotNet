using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SampleCLRModule {
    public static class Class1 {
        public static void InitializeCLRModule(IvmpDotNet.SDK.ICoreManager mgr) {
            mgr.EventManager.PlayerSpawn += (o, e) => {
                e.Player.GiveWeapon(10, 1337);
                e.Player.GiveHelmet();
                e.Player.Money = 1337;
                e.Player.DisplayText(100, 100, "asdff", 60 * 1000);
            };

            mgr.EventManager.PlayerCommand += (o, e) => {
                foreach (string cmd in e.Command) {
                    e.Player.SendMessage("ASDF: " + cmd, 0, false);
                }

                if (e.Command[0] == "/asdf") {
                    e.Player.SendMessage("You entered valid message", 0, false);
                    e.Player.GiveWeapon(18, 1337);
                } else if (e.Command[0] == "/test") {
                   var obj = mgr.ObjectManager.Create(2627789200, e.Player.Coordinates, new SDK.CVector3());
                   obj.AttachToPlayer(e.Player, e.Player.Coordinates, new SDK.CVector3(), -1);
                } else {
                    e.Player.SendMessage("You entered Invalid Message", 0, false);
                } 
            };

            

            mgr.VehicleManager.Create(
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

            Console.WriteLine("ASDF: {0}", mgr.ServerManager.GetWeaponName(10));
            Console.WriteLine("Loaded Sample CLR Module");
        }
    }
}
