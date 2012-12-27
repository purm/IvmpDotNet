using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    public interface IPickupManager {
        IPickup Create(Int32 modelhash, Byte type, UInt32 value, CVector3 vecPosition, CVector3 vecRotation);
    }
}
