using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet {
    public class PlayerManager : IPlayerManager {
        public bool SendMessageToAll(string szMessage, int iColor, bool sqbAllowFormatting) {
            return Imports.Players.Players_SendMessageToAll(szMessage, iColor, sqbAllowFormatting);
        }

        public bool DisplayTextForAll(float fPosX, float fPosY, string szText, int iTime) {
            return Imports.Players.Players_DisplayTextForAll(fPosX, fPosY, szText, iTime);
        }
    }
}
