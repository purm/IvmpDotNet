using IvmpDotNet.Imports;
using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.Wrappings {
    public class IVObject : IObject {
        public ushort ObjectId {
            get;
            set;
        }

        public int Model {
            get { return Objects.Objects_GetModel(ObjectId); }
        }

        public CVector3 Coordinates {
            get {
                return Objects.Objects_GetCoordinates(ObjectId);
            }
            set {
                Objects.Objects_SetCoordinates(ObjectId, value);
            }
        }

        public CVector3 Rotation {
            get {
                return Objects.Objects_GetRotation(ObjectId);
            }
            set {
                Objects.Objects_SetRotation(ObjectId, value);
            }
        }

        public byte Dimension {
            get {
                return Objects.Objects_GetDimension(ObjectId);
            }
            set {
                Objects.Objects_SetDimension(ObjectId, value);
            }
        }

        public bool AttachToPlayer(IPlayer player, CVector3 vecPos, CVector3 vecRot, int iBone) {
            return Objects.Objects_AttachToPlayer(ObjectId, player.PlayerId, vecPos, vecRot, iBone);
        }

        public bool Rotate(CVector3 vecRotation, float fSpeed) {
            return Objects.Objects_Rotate(ObjectId, vecRotation, fSpeed);
        }

        public bool Move(CVector3 vecMoveTarget, CVector3 vecMoveRot, float fSpeed) {
            return Objects.Objects_Move(ObjectId, vecMoveTarget, vecMoveRot, fSpeed);
        }

        public bool AttachVehicle(IVehicle vehicle, CVector3 vecPos, CVector3 vecRot) {
            return Objects.Objects_AttachVehicle(ObjectId, vehicle.VehicleId, vecPos, vecRot);
        }

        public bool AttachPed(IPlayer player, CVector3 vecPos, CVector3 vecRot) {
            return Objects.Objects_AttachPed(ObjectId, player.PlayerId, vecPos, vecRot);
        }

        public bool Delete() {
            return Objects.Objects_Delete(ObjectId);
        }
    }
}
