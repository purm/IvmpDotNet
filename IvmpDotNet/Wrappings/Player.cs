using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.Wrappings {
    public class Player : IvmpDotNet.SDK.IPlayer {
        public ushort PlayerId {
            get;
            set;
        }

        public bool IsConnected {
            get { return Imports.Players.Players_IsConnected(this.PlayerId); }
        }

        public string Name {
            get {
                return Imports.Players.Players_GetName(this.PlayerId);
            }
            set {
                Imports.Players.Players_SetName(this.PlayerId, value);
            }
        }

        public bool GiveWeapon(int iWeaponId, int iAmmo) {
            return Imports.Players.Players_GiveWeapon(this.PlayerId, iWeaponId, iAmmo);
        }

        public bool RemoveWeapons() {
            return Imports.Players.Players_RemoveWeapons(this.PlayerId);
        }
    }
}
