using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.SDK {
    /// <summary>
    /// Manages the world
    /// </summary>
   public interface IWorldManager {
       /// <summary>
       /// Sets the worlds time
       /// </summary>
       /// <param name="iHour">hours</param>
       /// <param name="iMinute">minutes</param>
       /// <returns>true if the time was set</returns>
       bool SetTime(Int32 iHour, Int32 iMinute);

       /// <summary>
       /// Sets the duration of a ingame minute
       /// </summary>
       /// <param name="iMinuteDuration">duration in ms</param>
       /// <returns>Returns true if the duration was set, false otherwise.</returns>
       bool SetMinuteDuration(Int32 iMinuteDuration);

       /// <summary>
       /// This function sets the current day of week.
       /// </summary>
       /// <param name="iDay">the day to set</param>
       /// <returns>Returns true if the day of week set, false otherwise.</returns>
       bool SetDayOfWeek(DaysOfWeek iDay);

       /// <summary>
       /// This function sets the traffic light state.
       /// </summary>
       /// <param name="iState">This function sets the traffic light state.</param>
       /// <returns>true</returns>
       bool SetTrafficLightsState(Int32 iState);

       /// <summary>
       /// This function toggles, if the traffic lights are locked.
       /// </summary>
       /// <param name="b">bool if locked</param>
       /// <returns>true</returns>
       bool SetTrafficLightsLocked(Boolean b);

       /// <summary>
       /// This function sets the traffic light phase duration.
       /// </summary>
       /// <param name="iPhase">the phase to set</param>
       /// <param name="iDuration">the duration of the phase in milliseconds</param>
       /// <returns>true</returns>
       bool SetTrafficLightsPhaseDuration(TrafficLightPhases iPhase, Int32 iDuration);
   }
}
