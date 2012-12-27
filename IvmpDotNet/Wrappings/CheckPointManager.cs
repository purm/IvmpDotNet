using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.Wrappings {
    public class CheckPointManager : ICheckPointManager {
        public ICheckPoint Create(int iType, CVector3 vecPosition, CVector3 vecTargetPosition, float fRadius) {
            ushort id = Imports.Checkpoints.Checkpoints_Create(iType, vecPosition, vecTargetPosition, fRadius);
            return new CheckPoint() {
                CheckPointId = id
            };
        }
    }
}
