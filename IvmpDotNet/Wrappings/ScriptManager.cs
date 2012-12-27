using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvmpDotNet.Imports;

namespace IvmpDotNet.Wrappings {
    public class ScriptManager : IScriptManager {
        public bool LoadScript(string szScript) {
            return Scripts.Scripts_LoadScript(szScript);
        }

        public bool UnloadScript(string szScript) {
            return Scripts.Scripts_UnloadScript(szScript);
        }

        public bool ReloadScript(string szScript) {
            return Scripts.Scripts_ReloadScript(szScript);
        }

        public bool LoadClientScript(string szScript) {
            return Scripts.Scripts_LoadClientScript(szScript);
        }

        public bool UnloadClientScript(string szScript) {
            return Scripts.Scripts_UnloadClientScript(szScript);
        }

        public bool ReloadClientScript(string szScript) {
            return Scripts.Scripts_ReloadClientScript(szScript);
        }

        public bool LoadClientResource(string szResource) {
            return Scripts.Scripts_LoadClientResource(szResource);
        }

        public bool UnloadClientResource(string szResource) {
            return Scripts.Scripts_UnloadClientResource(szResource);
        }

        public bool ReloadClientResource(string szResource) {
            return Scripts.Scripts_ReloadClientResource(szResource);
        }
    }
}
