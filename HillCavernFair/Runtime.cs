/*Runtime is also used frequently, so separating the method into its own class makes sense.*/

using System.Diagnostics;

namespace HillCavernFair
{
    public static class Runtime
    {
        static Runtime()
        {
            var ThisProcess = Process.GetCurrentProcess(); LastSystemTime = (long)(System.DateTime.Now - ThisProcess.StartTime).TotalMilliseconds; ThisProcess.Dispose();
            StopWatch = new Stopwatch(); StopWatch.Start();
        }
        private static long LastSystemTime;
        private static Stopwatch StopWatch;

        public static long CurrentRuntime { get { return StopWatch.ElapsedMilliseconds + LastSystemTime; } }

    }
}

