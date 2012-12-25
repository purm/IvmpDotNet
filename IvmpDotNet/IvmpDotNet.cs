using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace IvmpDotNet {
    public delegate void CallingFunctionEventHandler(object sender, CallingFunctionEventArgs e);

    public class CallingFunctionEventArgs : EventArgs {
        public string FunctionName { get; set; }
        public List<object> Parameters { get; set; }
        public object ReturnValue { get; set; }
    }

    public class IvmpDotNet {
        public event CallingFunctionEventHandler CallingFunction;

        public static readonly string ModuleName = "CLR Host";

        private static object _singletonMutex = new object();
        private static IvmpDotNet _singleton;
        public static IvmpDotNet Singleton {
            get {
                lock (_singletonMutex) {
                    if (_singleton == null)
                        _singleton = new IvmpDotNet();

                    return _singleton;
                }
            }
        }

        public bool InitModule(out string moduleName) {
            moduleName = ModuleName;

            Console.WriteLine("[{0}] InitModule", ModuleName);

            return true;
        }

        public void ScriptLoad() {
            Console.WriteLine("[{0}] ScriptLoad", ModuleName);
        }

        public void Pulse() {
            //Console.WriteLine("[{0}] Pulse", ModuleName);

            CallSquirrelFunction("log", new List<object>() { "HELLO IM LOGGING YEAYHH" });
        }

        public void SetupFunctions() {
            Console.WriteLine("[{0}] SetupFunctions", ModuleName);
        }

        public void SetupInterfaces() {
            Console.WriteLine("[{0}] SetupInterfaces", ModuleName);
        }

        public void SetupNewInterfaces() {
            Console.WriteLine("[{0}] SetupNewInterfaces", ModuleName);
        }

        public object CallSquirrelFunction(string functionName, List<object> parameters) {
            //Console.WriteLine("[{0}] CallSquirrelFunction {1}", ModuleName, functionName);

            if (CallingFunction != null) {
                var eArg = new CallingFunctionEventArgs() {
                    FunctionName = functionName,
                    Parameters = parameters
                };

                CallingFunction(this, eArg);

                return eArg.ReturnValue;
            }

            return null;
        }
    }
}
