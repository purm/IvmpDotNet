using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    public interface IObjectManager {
        IObject Create(Int64 modelhash, CVector3 vecPosition, CVector3 vecRotation);
        void CreateExplosion(CVector3 vecPos, Single fDensity);

        bool DoesExist(ushort id);
        IFire CreateFire(CVector3 vecPos, Single fDensity);
    }
}
