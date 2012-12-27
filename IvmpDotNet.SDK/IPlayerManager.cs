using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    public interface IPlayerManager {
        bool SendMessageToAll(String szMessage, Int32 iColor, Boolean sqbAllowFormatting);
        bool DisplayTextForAll(Single fPosX, Single fPosY, String szText, Int32 iTime);
    }
}
