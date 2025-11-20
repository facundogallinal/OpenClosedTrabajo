using System;

namespace Ucu.Poo.Ocp
{
    public class HolidayRule : ICanEnter
    {
        public bool CanEnter(Membership membership, DateTime date, int hour)
        {
            DayOfWeek dayOfWeek = date.DayOfWeek;
            
            //Feriados
            if (Calendar.IsHoliday(date))
            {
                if ( ((dayOfWeek == DayOfWeek.Monday || dayOfWeek == DayOfWeek.Tuesday ||
                       dayOfWeek == DayOfWeek.Wednesday || dayOfWeek == DayOfWeek.Thursday ||
                       dayOfWeek == DayOfWeek.Friday || dayOfWeek == DayOfWeek.Saturday) && hour >= 10 && hour < 18))
                {
                    if (membership == Membership.Premium)
                    {
                        return true;
                    }
                }
            }
            return false;

        }
    }
}