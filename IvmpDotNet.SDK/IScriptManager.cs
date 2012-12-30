using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Manages the squirrel scripts
    /// </summary>
    public interface IScriptManager {
        //GetScriptName(IntPtr pVM);
        /// <summary>
        /// Loads a server-side script.
        /// </summary>
        /// <param name="szScript">name of the file</param>
        /// <returns>Returns true if the script was loaded successfully, false otherwise.</returns>
        bool LoadScript(String szScript);

        /// <summary>
        /// Unloads a server-side script.
        /// </summary>
        /// <param name="szScript">the Script to unload</param>
        /// <returns>Returns true if the script was unloaded successfully, false otherwise.</returns>
        bool UnloadScript(String szScript);

        /// <summary>
        /// This function reloads a server-side script.
        /// </summary>
        /// <param name="szScript">the Script to reload</param>
        /// <returns>Returns true if the script was reloaded successfully, false otherwise.</returns>
        bool ReloadScript(String szScript);

        /// <summary>
        /// This function loads a client-side script.
        /// </summary>
        /// <param name="szScript">the Script to load</param>
        /// <returns>Returns true if the script was loaded successfully, false otherwise.</returns>
        bool LoadClientScript(String szScript);

        /// <summary>
        /// This function unloads a client-side script.
        /// </summary>
        /// <param name="szScript">the Script to unload</param>
        /// <returns>Returns true if the script was unloaded successfully, false otherwise.</returns>
        bool UnloadClientScript(String szScript);

        /// <summary>
        /// This function reloads a client-side script.
        /// </summary>
        /// <param name="szScript">the Script to reload</param>
        /// <returns>Returns true if the script was reloaded successfully, false otherwise.</returns>
        bool ReloadClientScript(String szScript);

        /// <summary>
        /// This function loads a client-side resource.
        /// </summary>
        /// <param name="szResource">the resource to load</param>
        /// <returns>Returns true if the resource was loaded successfully, false otherwise.</returns>
        bool LoadClientResource(String szResource);

        /// <summary>
        /// This function unloads a client-side resource.
        /// </summary>
        /// <param name="szResource">the resource to unload</param>
        /// <returns>Returns true if the resource was unloaded successfully, false otherwise.</returns>
        bool UnloadClientResource(String szResource);

        /// <summary>
        /// This function reloads a client-side resource.
        /// </summary>
        /// <param name="szResource">the resource to reload</param>
        /// <returns>Returns true if the resource was reloaded successfully, false otherwise.</returns>
        bool ReloadClientResource(String szResource);
    }
}
