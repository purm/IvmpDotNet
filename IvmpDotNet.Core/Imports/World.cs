using IvmpDotNet.SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace IvmpDotNet.Imports {
    public static class World {
        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean World_SetTime(Int32 iHour, Int32 iMinute);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean World_SetMinuteDuration(Int32 iMinuteDuration);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean World_SetDayOfWeek(Int32 iDay);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean World_SetTrafficLightsState(Int32 iState);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean World_SetTrafficLightsLocked(Boolean b);

        [DllImport("IvmpDotNetWrapper.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern Boolean World_SetTrafficLightsPhaseDuration(Int32 iPhase, Int32 iDuration);
    }
}
