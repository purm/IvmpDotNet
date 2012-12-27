using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    public interface IHashManager {
        string Md5(String toHash);
        string Md5File(String szFileName);
    }
}
