using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    public interface ICheckPointManager {
        ICheckPoint Create(Int32 iType, CVector3 vecPosition, CVector3 vecTargetPosition, Single fRadius);
    }
}
