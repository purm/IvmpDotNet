using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.Core {
    [Serializable]
    public class CLRModuleLoader {
        public AppDomain ModuleDomain { get; private set; }

        /// <summary>
        /// Loads all the CLR modules in a given path
        /// </summary>
        /// <param name="path">path to search for CLR Modules</param>
        public void LoadModules(string path) {
            IvmpDotNetCore.Singleton.Log("Loading Modules");

            List<string> modules = new List<string>();
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] fls = di.GetFiles("*.dll");

            //Get all the clr modules in the module folder
            foreach (FileInfo fis in fls)
                modules.Add(fis.FullName);

            AppDomainSetup setup = new AppDomainSetup();
            setup.AppDomainInitializer = new AppDomainInitializer(Initializing);
            setup.AppDomainInitializerArguments = modules.ToArray();

            ModuleDomain = AppDomain.CreateDomain("IvmpClrModulesDomain", System.AppDomain.CurrentDomain.Evidence, setup);
            ModuleDomain.UnhandledException += _moduleDomain_UnhandledException;
        }

        void _moduleDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e) {
            IvmpDotNetCore.Singleton.Log("Unhandled Exception - CLR Shutdown: {0} - Exception: {1}", e.IsTerminating, e.ExceptionObject.ToString());
        }

        private static void Initializing(string[] args) {
            foreach (string modPath in args) {
                Assembly assembly = Assembly.LoadFrom(modPath);
                foreach (var type in assembly.GetTypes()) {
                    if (type.IsPublic) {
                        if (!type.IsAbstract) {
                            Type moduleInterface = type.GetInterface("IvmpDotNet.SDK.IModule");
                            if (moduleInterface != null) {
                                IvmpDotNet.SDK.IModule mod = (IvmpDotNet.SDK.IModule)Activator.CreateInstance(type);
                                IvmpDotNetCore.Singleton.Log("Loading CLR Module {0}", System.IO.Path.GetFileName(modPath));
                                mod.Load(IvmpDotNetCore.Singleton);
                            }
                        }
                    }
                }
            }

            IvmpDotNetCore.Singleton.Log("All modules were loaded");
        }

        /// <summary>
        /// Calls every CLRModules "UnloadCLRModule" Method(s)
        /// </summary>
        public void UnloadModules() {
            IvmpDotNetCore.Singleton.Log("Unloading Modules");
            AppDomain.Unload(ModuleDomain);
            IvmpDotNetCore.Singleton.Log("All modules were unloaded");
        }

        /// <summary>
        /// Reloads all CLR Modules (if new were added to modules folder, they gonna be loaded, too);
        /// </summary>
        public void ReloadModules() {
            UnloadModules();
            LoadModules(IvmpDotNetCore.ModulePath);
        }
    }
}
