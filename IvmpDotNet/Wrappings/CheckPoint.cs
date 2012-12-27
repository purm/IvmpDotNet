using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvmpDotNet.Imports;

namespace IvmpDotNet.Wrappings {
    public class CheckPoint : ICheckPoint {
        public ushort CheckPointId {
            get;
            set;
        }

        public int Type {
            get {
                return Checkpoints.Checkpoints_GetType(CheckPointId);
            }
            set {
                Checkpoints.Checkpoints_SetType(CheckPointId, value);
            }
        }

        public CVector3 Position {
            get {
                return Checkpoints.Checkpoints_GetPosition(CheckPointId);
            }
            set {
                Checkpoints.Checkpoints_SetPosition(CheckPointId, value);
            }
        }

        public CVector3 TargetPosition {
            get {
                return Checkpoints.Checkpoints_GetTargetPosition(CheckPointId);
            }
            set {
                Checkpoints.Checkpoints_SetTargetPosition(CheckPointId, value);
            }
        }

        public float Radius {
            get {
                return Checkpoints.Checkpoints_GetRadius(CheckPointId);
            }
            set {
                Checkpoints.Checkpoints_SetRadius(CheckPointId, value);
            }
        }

        public byte Dimension {
            get {
                return (byte)Checkpoints.Checkpoints_GetDimension(CheckPointId);
            }
            set {
                Checkpoints.Checkpoints_SetDimension(CheckPointId, value);
            }
        }

        public bool Delete() {
            return Checkpoints.Checkpoints_Delete(CheckPointId);
        }

        public bool ShowForPlayer(IPlayer player) {
            return Checkpoints.Checkpoints_ShowForPlayer(CheckPointId, player.PlayerId);
        }

        public bool HideForPlayer(IPlayer player) {
            return Checkpoints.Checkpoints_HideForPlayer(CheckPointId, player.PlayerId);
        }

        public bool ShowForAll() {
            return Checkpoints.Checkpoints_ShowForAll(CheckPointId);
        }

        public bool HideForAll() {
            return Checkpoints.Checkpoints_HideForAll(CheckPointId);
        }
    }
}
