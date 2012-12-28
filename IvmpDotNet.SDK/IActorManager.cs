using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Manages the creation of actors
    /// </summary>
    public interface IActorManager {
        #region Methods

        /// <summary>
        /// Creates an actor.
        /// </summary>
        /// <param name="iModelId">The model (skin) of the actor</param>
        /// <param name="vecPosition">The actor's position</param>
        /// <param name="fHeading">The actor's rotation (heading)</param>
        /// <returns>The created Actor</returns>
        IActor Create(Int32 iModelId, CVector3 vecPosition, Single fHeading);

        #endregion
    }
}
