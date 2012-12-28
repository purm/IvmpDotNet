using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Manages Hashing
    /// </summary>
    public interface IHashManager {
        /// <summary>
        /// This function outputs a md5 string of a string.
        /// </summary>
        /// <param name="toHash">The string you like to hash</param>
        /// <returns>The MD5 Hash</returns>
        string Md5(String toHash);

        /// <summary>
        /// The MD5 Hash
        /// </summary>
        /// <param name="szFileName">The file in the /files folder you wish to hash</param>
        /// <returns>The MD5 Hash</returns>
        string Md5File(String szFileName);
    }
}
