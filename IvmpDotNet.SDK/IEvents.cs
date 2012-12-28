using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Represents the arguments for console events
    /// </summary>
    public class ConsoleEventArgs : EventArgs {
        /// <summary>
        /// The console text
        /// </summary>
        public string Text { get; set; }
    }

    /// <summary>
    /// Represents the arguments for the consoleOutput event
    /// </summary>
    public class ConsoleOutputEventArgs : ConsoleEventArgs {
        /// <summary>
        /// Set true to not print the output or add it to the log.
        /// </summary>
        public bool Cancel { get; set; }
    }

    /// <summary>
    /// Represents the arguments for player events
    /// </summary>
    public class PlayerEventArgs : EventArgs {
        /// <summary>
        /// The player, who triggerd the event
        /// </summary>
        public IPlayer Player { get; set; }
    }

    /// <summary>
    /// Represents the arguments for the playerCommand event
    /// </summary>
    public class PlayerCommandArgs : PlayerEventArgs {
        /// <summary>
        /// The commands (trimmed bei space) that the player inputted
        /// </summary>
        /// <example>
        /// Player entered: "/abc de fgh" -><br/>
        /// Command[0] = "/abc"
        /// Command[1] = "de"
        /// Command[2] = "fgh"
        /// </example>
        public string[] Command { get; set; }
    }

    /// <summary>
    /// Provides EventHandlers for all the events
    /// </summary>
    public interface IEvents {
        //Server Events
        /// <summary>
        /// Triggered on every server pulse.
        /// </summary>
        [FrequentlyEvent]
        event EventHandler ServerPulse;

        /// <summary>
        /// Triggered when text is entered in the console.
        /// </summary>
        event EventHandler<ConsoleEventArgs> ConsoleInput;

        /// <summary>
        /// Triggered when a text a message is output to the console.
        /// </summary>
        event EventHandler<ConsoleOutputEventArgs> ConsoleOutput;

        //Player Events
        /// <summary>
        /// Triggered when a player spawns.
        /// </summary>
        event EventHandler<PlayerEventArgs> PlayerSpawn;

        /// <summary>
        /// Triggered when a player enters a command in to the chat window.
        /// </summary>
        event EventHandler<PlayerCommandArgs> PlayerCommand;
    }
}
