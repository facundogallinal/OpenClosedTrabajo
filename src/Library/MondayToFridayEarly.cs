using System;

namespace Ucu.Poo.Ocp
{
    public class MondayToFridayEarlyRule : ICanEnter
    {
        public bool CanEnter(Membership membership, DateTime date, int hour)
        {
            DayOfWeek dayOfWeek = date.DayOfWeek;

            if ((dayOfWeek == DayOfWeek.Monday || dayOfWeek == DayOfWeek.Tuesday ||
                 dayOfWeek == DayOfWeek.Wednesday || dayOfWeek == DayOfWeek.Thursday ||
                 dayOfWeek == DayOfWeek.Friday) && hour >= 6 && hour < 10)
            {
                if (membership == Membership.Premium)
                {
                    return true;
                }
            }
            return false;
        }
    }
}