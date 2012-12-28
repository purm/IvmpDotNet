using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IvmpDotNet.Imports;

namespace IvmpDotNet.Wrappings {
    public class ObjectManager : IObjectManager {
        public IObject Create(long modelhash, CVector3 vecPosition, CVector3 vecRotation) {
            ushort id = Objects.Objects_Create(modelhash, vecPosition, vecRotation);
            return new IVObject() {
                ObjectId = id
            };
        }

        public void CreateExplosion(CVector3 vecPos, float fDensity) {
            Objects.Objects_CreateExplosion(vecPos, fDensity);
        }

        public IFire CreateFire(CVector3 vecPos, float fDensity) {
            ushort id = Objects.Objects_CreateFire(vecPos, fDensity);
            return new Fire() {
                FireId = id
            };
        }

        public bool DoesExist(ushort id) {
            return Imports.ObjectManager.DoesExist(id);
        }
    }
}
