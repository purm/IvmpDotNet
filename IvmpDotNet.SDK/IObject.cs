using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    public interface IFire {
        ushort FireId { get; set; }

        void Delete();
    }

    public interface IObject {
        ushort ObjectId { get; set; }

        int Model { get; }
        CVector3 Coordinates { get; set; }
        CVector3 Rotation { get; set; }
        byte Dimension { get; set; }

        bool AttachToPlayer(IPlayer player, CVector3 vecPos, CVector3 vecRot, Int32 iBone);
        bool Rotate(CVector3 vecRotation, Single fSpeed);
        bool Move(CVector3 vecMoveTarget, CVector3 vecMoveRot, Single fSpeed);
        bool AttachVehicle(IVehicle vehicle, CVector3 vecPos, CVector3 vecRot);
        bool AttachPed(IPlayer player, CVector3 vecPos, CVector3 vecRot);
        bool Delete();
    }
}
