using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet {
    static class CLRModuleLoader {
        static string _lastPath;
        static Dictionary<string, Assembly> _loadedModules = new Dictionary<string, Assembly>();

        /// <summary>
        /// Loads all the CLR modules in a given path and
        /// searches for a STATIC method in a STATIC class named "LoadCLRModule" and calls it with SDK ICoreManager as param
        /// </summary>
        /// <param name="path">path to search for CLR Modules</param>
        public static void LoadModules(string path) {
            _loadedModules.Clear();
            _lastPath = path;

            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] fls = di.GetFiles("*.dll");
            foreach (FileInfo fis in fls) {
                //try {;
                Assembly module = Assembly.LoadFile(fis.FullName);
                foreach (Type t in module.GetTypes()) {
                    if (t.IsAbstract && t.IsSealed) {
                        foreach (MethodInfo m in t.GetMethods()) {
                            if (m.Name == "LoadCLRModule" && m.IsStatic) {
                                m.Invoke(null, new object[] { IvmpDotNetCore.Singleton });
                                _loadedModules.Add(fis.FullName, module);
                            }
                        }
                    }
                }
                //} catch {
                //    Imports.Server.Server_Log(string.Format("[CLRModuleLoader]: Failed to load module '{0}'", fis.Name));
                //}
            }
        }

        /// <summary>
        /// Calls every CLRModules "UnloadCLRModule" Method(s)
        /// </summary>
        public static void UnloadModules() {
            foreach (var module in _loadedModules) {
                foreach (Type t in module.Value.GetTypes()) {
                    if (t.IsAbstract && t.IsSealed) {
                        foreach (MethodInfo m in t.GetMethods()) {
                            if (m.Name == "UnloadCLRModule" && m.IsStatic) {
                                m.Invoke(null, new object[] { });
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Reloads all CLR Modules (if new were added to modules folder, they gonna be loaded, too);
        /// </summary>
        public static void ReloadModules() {
            UnloadModules();
            LoadModules(_lastPath);
        }
    }
}
