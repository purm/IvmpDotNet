using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SampleCLRModule
{
    public static class Class1
    {
        public static void InitializeCLRModule(IvmpDotNet.SDK.ICoreManager mgr) {
            mgr.EventManager.PlayerSpawn += (o, e) => {
                e.Player.GiveWeapon(10, 1337);
                e.Player.GiveHelmet();
                e.Player.Money = 1337;
                e.Player.DisplayText(100, 100, "asdff", 60 * 1000);
            };

            Console.WriteLine("ASDF: {0}", mgr.ServerManager.GetWeaponName(10));
            Console.WriteLine("Loaded Sample CLR Module");
        }
    }
}
