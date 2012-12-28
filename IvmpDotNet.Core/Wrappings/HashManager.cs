using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.Wrappings {
    public class HashManager : IHashManager {
        public string Md5(string toHash) {
            return Marshal.PtrToStringAnsi(Imports.Hash.Hash_md5(toHash));
        }

        public string Md5File(string szFileName) {
            return Marshal.PtrToStringAnsi(Imports.Hash.Hash_md5File(szFileName));
        }
    }
}
