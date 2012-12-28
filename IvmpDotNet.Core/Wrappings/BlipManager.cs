using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.Wrappings {
    public class BlipManager : IBlipManager {
        public IBlip Create(int iSprite, CVector3 vecPosition, bool bShow) {
            ushort id = Imports.Blips.Blips_Create(iSprite, vecPosition, bShow);
            return new Blip() {
                BlipId = id
            };
        }
    }
}
