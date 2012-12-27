﻿using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IvmpDotNet {
    public class EventManager : IEvents {
        #region Events

        public event EventHandler ServerPulse;
        public event EventHandler<ConsoleEventArgs> ConsoleInput;
        public event EventHandler<ConsoleEventArgs> ConsoleOutput;
        public event EventHandler<PlayerEventArgs> PlayerSpawn;

        #endregion

        #region Methods

        public void RaisePlayerSpawn(ushort playerId) {
            if (PlayerSpawn != null)
                PlayerSpawn(this, new PlayerEventArgs() {
                    Player = new Wrappings.Player() {
                         PlayerId = playerId
                    }
                });
        }

        public void RaiseConsoleOutput(string outputtedText) {
            if (ConsoleOutput != null)
                ConsoleOutput(this, new ConsoleEventArgs() {
                    Text = outputtedText
                });
        }

        public void RaiseConsoleInput(string enteredText) {
            if (ConsoleInput != null)
                ConsoleInput(this, new ConsoleEventArgs() {
                    Text = enteredText
                });
        }

        public void RaiseServerPulse() {
            if (ServerPulse != null)
                ServerPulse(this, EventArgs.Empty);
        }

        #endregion
    }
}
