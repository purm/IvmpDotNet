using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    public interface IActorManager {
        IActor Create(Int32 iModelId, CVector3 vecPosition, Single fHeading);
    }
}
