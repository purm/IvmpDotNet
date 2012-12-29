using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// interface for all CLR modules
    /// </summary>
    public interface IModule {
        /// <summary>
        /// Called when the module is loading
        /// </summary>
        /// <param name="coreManager">The interface to ivmp</param>
        void Load(ICoreManager coreManager);

        /// <summary>
        /// Called when the module is unloading
        /// </summary>
        void Unload();
    }
}
