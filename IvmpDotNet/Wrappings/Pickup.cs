using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvmpDotNet.Imports;

namespace IvmpDotNet.Wrappings {
    public class Pickup : IPickup {
        public ushort PickupId {
            get;
            set;
        }

        public int Model {
            get { return Pickups.Pickups_GetModel(PickupId); }
        }

        public int Type {
            get { return Pickups.Pickups_GetType(PickupId); }
        }

        public uint Value {
            get {
                return Pickups.Pickups_GetValue(PickupId);
            }
            set {
                Pickups.Pickups_SetValue(PickupId, value);
            }
        }

        public CVector3 Coordinates {
            get {
                return Pickups.Pickups_GetCoordinates(PickupId);
            }
            set {
                Pickups.Pickups_SetCoordinates(PickupId, value);
            }
        }

        public CVector3 Rotation {
            get {
                return Pickups.Pickups_GetRotation(PickupId);
            }
            set {
                Pickups.Pickups_SetRotation(PickupId, value);
            }
        }

        public bool Delete() {
            return Pickups.Pickups_Delete(PickupId);
        }
    }
}
