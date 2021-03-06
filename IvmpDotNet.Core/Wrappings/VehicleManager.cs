﻿using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.Wrappings {
    public class VehicleManager : IVehicleManager {
        public IVehicle Create(VehicleModels iModelId, CVector3 vecPosition, CVector3 vecRotation, int color1, int color2, int color3, int color4, int respawn_delay) {
            ushort id = (ushort)Imports.Vehicles.Vehicles_Create((int)iModelId, vecPosition, vecRotation, color1, color2, color3, color4, respawn_delay);
            return new Vehicle() {
                VehicleId = id
            };
        }

        public void Remove(ushort vehicleId) {
            Imports.GetVehicleManager.GetVehicleManager_Remove(vehicleId);
        }

        public bool DoesExist(ushort vehicleId) {
            return DoesExist(vehicleId);
        }
    }
}
