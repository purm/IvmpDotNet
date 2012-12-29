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
        #region Properties

        public AppDomain ModuleDomain { get; private set; }
        public bool AreModulesLoaded { get; private set; }

        #endregion

        #region Constructors

        public CLRModuleLoader() {
            AreModulesLoaded = false;

            if (AppDomain.CurrentDomain.IsDefaultAppDomain())
                AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
        }

        #endregion

        #region Callbacks

        Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args) {
            //TODO: Cleaner solution; this is little hacky
            try {
                return Assembly.LoadFrom(args.Name);
            } catch (FileNotFoundException) {
                try {
                    return Assembly.LoadFrom(Path.Combine(Directory.GetCurrentDirectory(), "Modules", new AssemblyName(args.Name).Name + ".dll"));
                } catch (FileNotFoundException) {
                    return Assembly.LoadFrom(Path.Combine(Directory.GetCurrentDirectory(), "CLRModules", new AssemblyName(args.Name).Name + ".dll"));
                }
            }
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

        #endregion

        #region Methods

        /// <summary>
        /// Loads all the CLR modules in a given path
        /// </summary>
        /// <param name="path">path to search for CLR Modules</param>
        public void LoadModules(string path) {
            if (AreModulesLoaded)
                throw new InvalidOperationException();

            IvmpDotNetCore.Singleton.Log("Loading Modules");

            List<string> modules = new List<string>();
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] fls = di.GetFiles("*.dll");

            //Get all the clr modules in the module folder
            foreach (FileInfo fis in fls)
                modules.Add(fis.FullName);

            //Setup an isolated domain for modules
            AppDomainSetup setup = new AppDomainSetup();
            setup.AppDomainInitializer = new AppDomainInitializer(Initializing);
            setup.AppDomainInitializerArguments = modules.ToArray();
            setup.PrivateBinPath = "Modules";
            setup.ShadowCopyFiles = "true";

            ModuleDomain = AppDomain.CreateDomain("IvmpClrModulesDomain", null, setup);
            ModuleDomain.UnhandledException += _moduleDomain_UnhandledException;

            AreModulesLoaded = true;
        }

        void _moduleDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e) {
            IvmpDotNetCore.Singleton.Log("Unhandled Exception - CLR Shutdown: {0} - Exception: {1}", e.IsTerminating, e.ExceptionObject.ToString());
        }

        /// <summary>
        /// Calls every CLRModules "UnloadCLRModule" Method(s)
        /// </summary>
        public void UnloadModules() {
            if (!AreModulesLoaded)
                throw new InvalidOperationException();

            IvmpDotNetCore.Singleton.Log("Unloading Modules");
            foreach (var assembly in ModuleDomain.GetAssemblies()) {
                foreach (var type in assembly.GetTypes()) {
                    if (type.IsPublic) {
                        if (!type.IsAbstract) {
                            Type moduleInterface = type.GetInterface("IvmpDotNet.SDK.IModule");
                            if (moduleInterface != null) {
                                IvmpDotNet.SDK.IModule mod = (IvmpDotNet.SDK.IModule)Activator.CreateInstance(type);
                                IvmpDotNetCore.Singleton.Log("Unloading CLR Module {0}", System.IO.Path.GetFileName(assembly.Location));
                                mod.Unload();
                            }
                        }
                    }
                }
            }

            AppDomain.Unload(ModuleDomain);
            ModuleDomain = null;
            AreModulesLoaded = false;

            IvmpDotNetCore.Singleton.Log("All modules were unloaded");
        }

        /// <summary>
        /// Reloads all CLR Modules (if new were added to modules folder, they gonna be loaded, too);
        /// </summary>
        public void ReloadModules() {
            UnloadModules();
            LoadModules(IvmpDotNetCore.ModulePath);
        }

        #endregion
    }
}
