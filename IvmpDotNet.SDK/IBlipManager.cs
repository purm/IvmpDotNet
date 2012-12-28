using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Manages the blip creation
    /// </summary>
    public interface IBlipManager {
        /// <summary>
        /// Creates a blip
        /// </summary>
        /// <param name="iSprite">Sprite of the blip</param>
        /// <param name="vecPosition">Position of the blip</param>
        /// <param name="bShow">Show or Hide?</param>
        /// <returns>The created blip</returns>
        IBlip Create(Int32 iSprite, CVector3 vecPosition, Boolean bShow);
    }
}
