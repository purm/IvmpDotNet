using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvmpDotNet.Imports;
using System.Runtime.InteropServices;

namespace IvmpDotNet.Wrappings {
    public class Actor : IActor {
        public ushort ActorId {
            get;
            set;
        }

        public bool IsValid {
            get { return Actors.Actors_IsValid(ActorId); }
        }

        public CVector3 Coordinates {
            get {
                return Actors.Actors_GetCoordinates(ActorId);
            }
            set {
                Actors.Actors_SetCoordinates(ActorId, value);
            }
        }

        public float Heading {
            get {
                return Actors.Actors_GetHeading(ActorId);
            }
            set {
                Actors.Actors_SetHeading(ActorId, value);
            }
        }

        public PedModels Model {
            get { return (PedModels)Actors.Actors_GetModel(ActorId); }
        }

        public string Name {
            get {
                return Marshal.PtrToStringAnsi(Actors.Actors_GetName(ActorId));
            }
            set {
                Actors.Actors_SetName(ActorId, value);
            }
        }

        public bool Nametag {
            set { Actors.Actors_ToggleNametag(ActorId, value); }
        }

        public bool Blip {
            set { Actors.Actors_ToggleBlip(ActorId, value); }
        }

        public int Color {
            get {
                return Actors.Actors_GetColor(ActorId);
            }
            set {
                Actors.Actors_SetColor(ActorId, value);
            }
        }

        public bool Frozen {
            set { Actors.Actors_ToggleFrozen(ActorId, value); }
        }

        public bool Helmet {
            set { Actors.Actors_ToggleHelmet(ActorId, value); }
        }

        public bool RemoveFromVehicle() {
            return Actors.Actors_RemoveFromVehicle(ActorId);
        }

        public bool WarpIntoVehicle(IVehicle vehicle, int seatid) {
            return Actors.Actors_WarpIntoVehicle(ActorId, vehicle.VehicleId, seatid);
        }

        public bool Delete() {
            return Actors.Actors_Delete(ActorId);
        }

        public bool WalkToCoordinatesForPlayer(IPlayer player, CVector3 vecPosition, int iType) {
            return Actors.Actors_WalkToCoordinates(player.PlayerId, ActorId, vecPosition, iType);
        }

        public bool DriveToCoordinates(CVector3 vecDriveTo, CVector3 vecDriveRot, bool bStop) {
            return Actors.Actors_DriveToCoordinates(ActorId, vecDriveTo, vecDriveRot, bStop);
        }

        public bool ForceAnim(string szGroup, string szAnim) {
            return Actors.Actors_ForceAnim(ActorId, szGroup, szAnim);
        }
    }
}
