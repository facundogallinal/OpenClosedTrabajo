using System;

namespace Ucu.Poo.Ocp
{
    public class SaturdayRule: ICanEnter
    {
        public bool CanEnter(Membership membership, DateTime date, int hour)
        {
            DayOfWeek dayOfWeek = date.DayOfWeek;
            if (dayOfWeek == DayOfWeek.Saturday && hour >= 8 && hour < 20)
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