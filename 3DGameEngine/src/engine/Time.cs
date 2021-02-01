using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _3DGameEngine.src.engine
{
    class Time
    {
        public static long SECOND = 1000000000L;

        private static double delta;

        public static long getTime() {
            return nanoTime();
        }

        private static long nanoTime()
        {
            long nano = 10000L * Stopwatch.GetTimestamp();
            nano /= TimeSpan.TicksPerMillisecond;
            nano *= 100L;
            return nano;
        }

        public static double getDelta() { return delta; }

        public static void setDelta(double _delta) { delta = _delta; }

    }
}
