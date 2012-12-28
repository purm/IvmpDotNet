using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.Wrappings {
    public class NetworkManager : INetworkManager {
        public bool AddBan(string strIp, uint uiSeconds) {
            return Imports.NetworManager.NetworkManager_AddBan(strIp, uiSeconds);
        }
    }
}
