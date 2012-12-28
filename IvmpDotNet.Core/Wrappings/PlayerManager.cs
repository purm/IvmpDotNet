using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.Wrappings {
    public class PlayerManager : IPlayerManager {
        public bool SendMessageToAll(string szMessage, int iColor, bool sqbAllowFormatting) {
            return Imports.Players.Players_SendMessageToAll(szMessage, iColor, sqbAllowFormatting);
        }

        public bool DisplayTextForAll(float fPosX, float fPosY, string szText, int iTime) {
            return Imports.Players.Players_DisplayTextForAll(fPosX, fPosY, szText, iTime);
        }

        public IPlayer GetAt(ushort playerId) {
            return new Player() {
                PlayerId = playerId
            };
        }

        public bool DoesExist(ushort playerId) {
            return Imports.GetPlayerManager.GetPlayerManager_DoesExist(playerId);
        }

        public void Add(ushort playerId, string sPlayerName) {
            Imports.GetPlayerManager.GetPlayerManager_Add(playerId, sPlayerName);
        }

        public bool Remove(ushort playerId, byte byteReason) {
            return Imports.GetPlayerManager.GetPlayerManager_Remove(playerId, byteReason);
        }

        public bool IsNameInUse(string szNick) {
            return Imports.GetPlayerManager.GetPlayerManager_IsNameInUse(szNick);
        }

        public IPlayer GetPlayerFromName(string sNick) {
            ushort id = Imports.GetPlayerManager.GetPlayerManager_GetPlayerFromName(sNick);
            return GetAt(id);
        }
    }
}
