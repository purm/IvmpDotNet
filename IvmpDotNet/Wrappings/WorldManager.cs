using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.Wrappings {
    public class WorldManager : IWorldManager {
        public bool SetTime(int iHour, int iMinute) {
            return Imports.World.World_SetTime(iHour, iMinute);
        }

        public bool SetMinuteDuration(int iMinuteDuration) {
            return Imports.World.World_SetMinuteDuration(iMinuteDuration);
        }

        public bool SetDayOfWeek(int iDay) {
            return Imports.World.World_SetDayOfWeek(iDay);
        }

        public bool SetTrafficLightsState(int iState) {
            return Imports.World.World_SetTrafficLightsState(iState);
        }

        public bool SetTrafficLightsLocked(bool b) {
            return Imports.World.World_SetTrafficLightsLocked(b);
        }

        public bool SetTrafficLightsPhaseDuration(int iPhase, int iDuration) {
            return Imports.World.World_SetTrafficLightsPhaseDuration(iPhase, iDuration);
        }
    }
}
