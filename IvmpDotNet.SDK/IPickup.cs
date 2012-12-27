using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    public interface IPickup {
        ushort PickupId { get; set; }

        int Model { get; }
        int Type { get; }
        UInt32 Value { get; set; }
        CVector3 Coordinates { get; set; }
        CVector3 Rotation { get; set; }

        bool Delete();
    }
}
