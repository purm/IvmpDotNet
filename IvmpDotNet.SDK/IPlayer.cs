using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    public interface IPlayer {
        ushort PlayerId { get; set; }

        bool IsConnected { get; }
        string Name { get; set; }
        bool GiveWeapon(Int32 iWeaponId, Int32 iAmmo);
        bool RemoveWeapons();
    }
}
