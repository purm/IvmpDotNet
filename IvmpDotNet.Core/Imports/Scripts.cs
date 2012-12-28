using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace IvmpDotNet.Imports {
    public static class Scripts {
        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Scripts_GetScriptName(IntPtr pVM);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Scripts_LoadScript(String szScript);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Scripts_UnloadScript(String szScript);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Scripts_ReloadScript(String szScript);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Scripts_LoadClientScript(String szScript);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Scripts_UnloadClientScript(String szScript);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Scripts_ReloadClientScript(String szScript);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Scripts_LoadClientResource(String szResource);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Scripts_UnloadClientResource(String szResource);

        [DllImport(IvmpDotNet.Core.Imports.Common.ImportDllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean Scripts_ReloadClientResource(String szResource);
    }
}
