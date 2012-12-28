using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Manages checkpoint creation
    /// </summary>
    public interface ICheckPointManager {
        #region Methods

        /// <summary>
        /// Creates a checkpoint
        /// </summary>
        /// <param name="iType">The type of the checkpoints</param>
        /// <param name="vecPosition">The position</param>
        /// <param name="vecTargetPosition">The target position</param>
        /// <param name="fRadius">The radius</param>
        /// <returns>The checkpoint object</returns>
        ICheckPoint Create(CheckpointTypes iType, CVector3 vecPosition, CVector3 vecTargetPosition, Single fRadius);

        #endregion
    }
}
