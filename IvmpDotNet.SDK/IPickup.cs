using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Represents a pickup
    /// </summary>
    public interface IPickup {
        #region Properties

        /// <summary>
        /// Gets or sets the pickup's id
        /// </summary>
        ushort PickupId { get; set; }

        /// <summary>
        /// Gets the model
        /// </summary>
        PickupModels Model { get; }

        /// <summary>
        /// Gets the type
        /// </summary>
        PickupTypes Type { get; }

        /// <summary>
        /// Gets or sets the Value
        /// </summary>
        UInt32 Value { get; set; }

        /// <summary>
        /// Gets or sets the coordinates
        /// </summary>
        CVector3 Coordinates { get; set; }

        /// <summary>
        /// Gets or sets the checkpoint's rotation
        /// </summary>
        CVector3 Rotation { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Deletes the pickup
        /// </summary>
        /// <returns>True if the deletion succeded</returns>
        bool Delete();

        #endregion
    }
}
