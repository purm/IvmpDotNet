using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvmpDotNet.Imports;
using System.Runtime.InteropServices;

namespace IvmpDotNet.Wrappings {
    public class Blip : IBlip {
        public ushort BlipId {
            get;
            set;
        }

        public CVector3 Coordinates {
            get {
                return Blips.Blips_GetCoordinates(BlipId);
            }
            set {
                Blips.Blips_SetCoordinates(BlipId, value);
            }
        }

        public int Color {
            get {
                return Blips.Blips_GetColor(BlipId);
            }
        }

        public string Name {
            get { return Marshal.PtrToStringAnsi(Blips.Blips_GetName(BlipId)); }
        }

        public float Size {
            get { return Blips.Blips_GetSize(BlipId); }
        }

        public bool SetName(string szName, IPlayer player) {
            return Blips.Blips_SetName(BlipId, szName, player.PlayerId);
        }

        public bool ToggleRoute(bool bToggle, IPlayer player) {
            return Blips.Blips_ToggleRoute(BlipId, bToggle, player.PlayerId);
        }

        public bool ToggleShortRange(bool bToggle, IPlayer player) {
            return Blips.Blips_ToggleShortRange(BlipId, bToggle, player.PlayerId);
        }

        public bool SetSize(float fSize, IPlayer player) {
            return Blips.Blips_SetSize(BlipId, fSize, player.PlayerId);
        }

        public bool Delete() {
            return Blips.Blips_Delete(BlipId);
        }

        public bool SetColor(int color, IPlayer player) {
            return Blips.Blips_SetColor(BlipId, color, player.PlayerId);
        }
    }
}
