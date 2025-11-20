using System;

namespace Ucu.Poo.Ocp
{
    public class SundayRule : ICanEnter
    {
        public bool CanEnter(Membership membership, DateTime date, int hour)
        {
            DayOfWeek dayOfWeek = date.DayOfWeek;
            if (dayOfWeek == DayOfWeek.Sunday)
            {
                return false;
            }

            return false;
        }
    }
}