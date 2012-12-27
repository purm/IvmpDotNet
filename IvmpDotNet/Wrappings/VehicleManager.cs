using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.Wrappings {
    public class VehicleManager : IVehicleManager {
        public IVehicle Create(int iModelId, CVector3 vecPosition, CVector3 vecRotation, int color1, int color2, int color3, int color4, int respawn_delay) {
            ushort id = (ushort)Imports.Vehicles.Vehicles_Create(iModelId, vecPosition, vecRotation, color1, color2, color3, color4, respawn_delay);
            return new Vehicle() {
                VehicleId = id
            };
        }
    }
}
