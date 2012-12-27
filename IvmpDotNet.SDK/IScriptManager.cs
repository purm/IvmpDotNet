using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    public interface IScriptManager {
        //GetScriptName(IntPtr pVM);
        bool LoadScript(String szScript);
        bool UnloadScript(String szScript);
        bool ReloadScript(String szScript);
        bool LoadClientScript(String szScript);
        bool UnloadClientScript(String szScript);
        bool ReloadClientScript(String szScript);
        bool LoadClientResource(String szResource);
        bool UnloadClientResource(String szResource);
        bool ReloadClientResource(String szResource);
    }
}
