using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.Wrappings {
    public class PickupManager : IPickupManager {
        public IPickup Create(PickupModels modelhash, PickupTypes type, uint value, CVector3 vecPosition, CVector3 vecRotation) {
            ushort id = Imports.Pickups.Pickups_Create((uint)modelhash, (byte)type, value, vecPosition, vecRotation);
            return new Pickup() {
                PickupId = id
            };
        }
    }
}
