using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    public interface IPlayerManager {
        bool SendMessageToAll(String szMessage, Int32 iColor, Boolean sqbAllowFormatting);
        bool DisplayTextForAll(Single fPosX, Single fPosY, String szText, Int32 iTime);

        IPlayer GetAt(ushort playerId);
        bool DoesExist(ushort playerId);
        void Add(ushort playerId, String sPlayerName);
        bool Remove(ushort playerId, Byte byteReason);
        bool IsNameInUse(String szNick);
        IPlayer GetPlayerFromName(String sNick);
    }
}
