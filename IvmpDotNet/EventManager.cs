using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IvmpDotNet {
    public class EventManager : IEvents {
        #region Events

        public event EventHandler ServerPulse;
        public event EventHandler<ConsoleEventArgs> ConsoleInput;
        public event EventHandler<ConsoleOutputEventArgs> ConsoleOutput;
        public event EventHandler<PlayerEventArgs> PlayerSpawn;
        public event EventHandler<PlayerCommandArgs> PlayerCommand;

        #endregion

        #region Methods

        public int RaisePlayerCommand(ushort playerId, string command) {
            if (PlayerCommand != null)
                PlayerCommand(this, new PlayerCommandArgs() {
                    Player = new Wrappings.Player() {
                        PlayerId = playerId
                    },
                    Command = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                });

            return 1;
        }

        public int RaisePlayerSpawn(ushort playerId) {
            if (PlayerSpawn != null)
                PlayerSpawn(this, new PlayerEventArgs() {
                    Player = new Wrappings.Player() {
                        PlayerId = playerId
                    }
                });

            return 1;
        }

        public int RaiseConsoleOutput(string outputtedText) {
            if (ConsoleOutput != null){
                ConsoleOutputEventArgs args = new ConsoleOutputEventArgs() {
                    Text = outputtedText
                };

                ConsoleOutput(this, args);
                if (args.Cancel)
                    return 0;
            }

            return 1;
        }

        public int RaiseConsoleInput(string enteredText) {
            if (ConsoleInput != null)
                ConsoleInput(this, new ConsoleEventArgs() {
                    Text = enteredText
                });

            return 1;
        }

        public int RaiseServerPulse() {
            if (ServerPulse != null)
                ServerPulse(this, EventArgs.Empty);

            return 1;
        }

        #endregion
    }
}
