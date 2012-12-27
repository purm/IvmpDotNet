using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace IvmpDotNet.Imports {
    public static class Hash {
        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Hash_md5(String toHash);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr Hash_md5File(String szFileName);
    }
}
