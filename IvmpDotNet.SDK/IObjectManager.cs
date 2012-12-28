using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Manages object creation & co.
    /// </summary>
    public interface IObjectManager {
        #region Methods

        /// <summary>
        /// Creates an object
        /// </summary>
        /// <param name="modelhash">the object's model</param>
        /// <param name="vecPosition">position to place the object</param>
        /// <param name="vecRotation">rotation to rotate the object</param>
        /// <returns>The object-object</returns>
        IObject Create(Int64 modelhash, CVector3 vecPosition, CVector3 vecRotation);

        /// <summary>
        /// Creates an explosion
        /// </summary>
        /// <param name="vecPos">Position where to create the explosion</param>
        /// <param name="fDensity">The density of the explosion</param>
        void CreateExplosion(CVector3 vecPos, Single fDensity);

        /// <summary>
        /// Checks if an object exists
        /// </summary>
        /// <param name="id">object id</param>
        /// <returns>true if exists</returns>
        bool DoesExist(ushort id);

        /// <summary>
        /// Creates fire
        /// </summary>
        /// <param name="vecPos">position where to create the fire</param>
        /// <param name="fDensity">the density of the fire</param>
        /// <returns>the fire object</returns>
        IFire CreateFire(CVector3 vecPos, Single fDensity);

        #endregion
    }
}
