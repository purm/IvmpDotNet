using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.Wrappings {
    public class PickupManager : IPickupManager {
        public IPickup Create(int modelhash, byte type, uint value, CVector3 vecPosition, CVector3 vecRotation) {
            ushort id = Imports.Pickups.Pickups_Create(modelhash, type, value, vecPosition, vecRotation);
            return new Pickup() {
                PickupId = id
            };
        }
    }
}
