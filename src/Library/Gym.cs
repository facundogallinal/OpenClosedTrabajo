using System;
using System.Collections.Generic;

namespace Ucu.Poo.Ocp
{
    /// <summary>
    /// Esta clase representa un gimnasio con reglas de acceso basadas en el
    /// tipo de usuario, día de la semana y hora del día.
    /// </summary>
    public class Gym
    {
        private List<ICanEnter> rules = new List<ICanEnter>()
        {
            new HolidayRule(),
            new MondayToFridayEarlyRule(),
            new GeneralDayRule(),
            new EveningRule(),
            new SaturdayRule(),
            new SundayRule()
        };
        
        
        public bool CanEnter(Membership membership, DateTime date, int hour)
        {
            foreach (var rule in rules)
            {
                if (rule.CanEnter(membership, date, hour))
                    return true;
            }

            return false;
        }
    }
}

