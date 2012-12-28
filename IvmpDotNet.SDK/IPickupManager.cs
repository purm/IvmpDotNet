using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Manages pickup creation
    /// </summary>
    public interface IPickupManager {
        /// <summary>
        /// Creates a pickup
        /// </summary>
        /// <param name="modelhash">the pickup's model</param>
        /// <param name="type">the pickup's type</param>
        /// <param name="value">the pickup's value</param>
        /// <param name="vecPosition">the pickup's position</param>
        /// <param name="vecRotation">the pickup's rotation</param>
        /// <returns>the created pickup-object</returns>
        IPickup Create(PickupModels modelhash, PickupTypes type, UInt32 value, CVector3 vecPosition, CVector3 vecRotation);
    }
}
