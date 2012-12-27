using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    public interface ICoreManager {
        IEvents EventManager { get; }
        IPlayerManager PlayerManager { get; }
    }
}
