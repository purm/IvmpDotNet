using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    public class ConsoleEventArgs : EventArgs {
        public string Text { get; set; }
    }

    public class PlayerEventArgs : EventArgs {
        public IPlayer Player { get; set; }
    }

    public class PlayerCommandArgs : PlayerEventArgs {
        public string[] Command { get; set; }
    }

    public interface IEvents {
        event EventHandler ServerPulse;
        event EventHandler<ConsoleEventArgs> ConsoleInput;
        event EventHandler<ConsoleEventArgs> ConsoleOutput;
        event EventHandler<PlayerEventArgs> PlayerSpawn;
        event EventHandler<PlayerCommandArgs> PlayerCommand;
    }
}
