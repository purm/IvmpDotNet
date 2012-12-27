using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    public interface IBlip {
        ushort BlipId { get; set; }

        CVector3 Coordinates { get; set; }
        int Color { get; }
        string Name { get; }
        Single Size { get; }

        bool SetColor(int color, IPlayer player);
        bool SetName(String szName, IPlayer player);
        bool ToggleRoute(Boolean bToggle, IPlayer player);
        bool ToggleShortRange(Boolean bToggle, IPlayer player);
        bool SetSize(Single fSize, IPlayer player);
        bool Delete();
    }
}
