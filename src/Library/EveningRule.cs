using System;

namespace Ucu.Poo.Ocp
{
    public class EveningRule:ICanEnter
    {
        public bool CanEnter(Membership membership, DateTime date, int hour)
        {
            DayOfWeek dayOfWeek = date.DayOfWeek;

            if ((dayOfWeek == DayOfWeek.Monday || dayOfWeek == DayOfWeek.Tuesday ||
                 dayOfWeek == DayOfWeek.Wednesday || dayOfWeek == DayOfWeek.Thursday ||
                 dayOfWeek == DayOfWeek.Friday) && hour >= 17 && hour < 21)
            {
                if (membership == Membership.Premium || membership == Membership.Basic)
                {
                    return true;
                }
            }
            return false;
        }
    }
}