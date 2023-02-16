using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTimetableLibrary
{
    public class Calculations
    {
        public string AvailablePeriods(TimeSpan[] startTimes,
            int[] durations,
            TimeSpan beginWorkingTime,
            TimeSpan endWorkingTime,
            int consultationTim)
        {
            TimeSpan arrival = beginWorkingTime;
            TimeSpan departure = endWorkingTime;
            TimeSpan workTime = arrival - departure;
            for (int i = 0; i < workTime.Hours; i++)
            {

            }
        }
    }
}
