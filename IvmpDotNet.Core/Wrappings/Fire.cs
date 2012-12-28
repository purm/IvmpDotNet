using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.Wrappings {
    public class Fire : IFire {
        public ushort FireId {
            get;
            set;
        }

        public void Delete() {
            Imports.Objects.Objects_DeleteFire(FireId);
        }
    }
}
