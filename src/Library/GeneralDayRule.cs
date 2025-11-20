using System;

namespace Ucu.Poo.Ocp
{
    public class GeneralDayRule : ICanEnter
    {
        public bool CanEnter(Membership membership, DateTime date, int hour)
        {
            DayOfWeek dayOfWeek = date.DayOfWeek;

            if ((dayOfWeek == DayOfWeek.Monday || dayOfWeek == DayOfWeek.Tuesday ||
                 dayOfWeek == DayOfWeek.Wednesday || dayOfWeek == DayOfWeek.Thursday ||
                 dayOfWeek == DayOfWeek.Friday) && hour >= 10 && hour < 17)
            {
                if (membership == Membership.Premium ||
                    membership == Membership.Basic ||
                    membership == Membership.DayPass)
                {
                    return true;
                }
            }
            return false;

        }
    }
}