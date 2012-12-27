using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    public interface IActor {
        ushort ActorId { get; set; }

        bool IsValid { get; }
        CVector3 Coordinates { set; get; }
        Single Heading { set; get; }
        int Model { get; }
        string Name { get; set; }
        bool Nametag { set; }
        bool Blip { set; }
        int Color { get; set; }
        bool Frozen { set; }
        bool Helmet { set; }

        bool RemoveFromVehicle();
        bool WarpIntoVehicle(Int32 vehicleid, Int32 seatid);
        bool Delete();
        bool WalkToCoordinatesForPlayer(IPlayer player, CVector3 vecPosition, Int32 iType);
        bool DriveToCoordinates(CVector3 vecDriveTo, CVector3 vecDriveRot, Boolean bStop);
        bool ForceAnim(String szGroup, String szAnim);
    }
}
