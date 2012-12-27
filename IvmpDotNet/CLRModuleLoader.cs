using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet {
    static class CLRModuleLoader {
        public static void LoadModules(string path) {
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] fls = di.GetFiles("*.dll");
            foreach (FileInfo fis in fls) {
                //try {
                    Assembly module = Assembly.LoadFile(fis.FullName);
                    foreach (Type t in module.GetTypes()) {
                        if (t.IsAbstract && t.IsSealed) {
                            foreach (MethodInfo m in t.GetMethods()) {
                                if (m.Name == "InitializeCLRModule" && m.IsStatic) {
                                    m.Invoke(null, new object[] { IvmpDotNetCore.Singleton });
                                }
                            }
                        }
                    }
                //} catch {
                //    Imports.Server.Server_Log(string.Format("[CLRModuleLoader]: Failed to load module '{0}'", fis.Name));
                //}
            }
        }
    }
}
