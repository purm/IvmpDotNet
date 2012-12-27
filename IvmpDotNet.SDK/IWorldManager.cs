using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
   public interface IWorldManager {
       bool SetTime(Int32 iHour, Int32 iMinute);
       bool SetMinuteDuration(Int32 iMinuteDuration);
       bool SetDayOfWeek(Int32 iDay);
       bool SetTrafficLightsState(Int32 iState);
       bool SetTrafficLightsLocked(Boolean b);
       bool SetTrafficLightsPhaseDuration(Int32 iPhase, Int32 iDuration);
   }
}
