using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    public interface ICheckPoint {
        ushort CheckPointId { get; set; }

        int Type { get; set; }
        CVector3 Position { get; set; }
        CVector3 TargetPosition { get; set; }
        Single Radius { get; set; }
        Byte Dimension { get; set; }

        bool Delete();
        bool ShowForPlayer(IPlayer player);
        bool HideForPlayer(IPlayer player);
        bool ShowForAll();
        bool HideForAll();
    }
}
