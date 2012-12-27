using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    public interface IVehicleManager {
        IVehicle Create(Int32 iModelId, CVector3 vecPosition, CVector3 vecRotation, Int32 color1, Int32 color2, Int32 color3, Int32 color4, Int32 respawn_delay);

        void Remove(ushort vehicleId);
        bool DoesExist(ushort vehicleId);
    }
}
