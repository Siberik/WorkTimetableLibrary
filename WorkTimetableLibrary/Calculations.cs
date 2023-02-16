using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTimetableLibrary
{
    public class Calculations
    {
        /// <summary>
        /// Возвращает список свободных временных интервалов (заданного размера) в графике сотрудника для формирования оптимального графика работы сотрудников
        /// </summary>
        /// <param name="startTimes">
        /// Начало
        /// </param>
        /// <param name="durations">
        /// Длительность
        /// </param>
        /// <param name="beginWorkingTime">
        /// Начало рабочего дня
        /// </param>
        /// <param name="endWorkingTime">
        /// Конец рабочего дня
        /// </param>
        /// <param name="consultationTim">
        /// Время приёма
        /// </param>   
        /// <returns>
        /// Список свободных временных интервалов
        /// </returns>
        public string[] AvailablePeriods(TimeSpan[] startTimes,
            int[] durations,
            TimeSpan beginWorkingTime,
            TimeSpan endWorkingTime,
            int consultationTim)
        {
             string[] calc= { };
            TimeSpan arrival = beginWorkingTime;
            TimeSpan departure = endWorkingTime;
            TimeSpan workTime = arrival - departure;
            for (int i = 0; i < workTime.Hours; i++)
            {
                calc[i] = Convert.ToString(Convert.ToInt32 (consultationTim));
                Console.WriteLine(calc[i]); 
            }
            return calc;
            
        }
    }
}
