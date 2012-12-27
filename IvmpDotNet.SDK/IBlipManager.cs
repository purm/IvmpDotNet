using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    public interface IBlipManager {
        IBlip Create(Int32 iSprite, CVector3 vecPosition, Boolean bShow);
    }
}
