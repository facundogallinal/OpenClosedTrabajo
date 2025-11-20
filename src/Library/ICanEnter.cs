using System;

namespace Ucu.Poo.Ocp
{
    public interface ICanEnter
    {
        
        bool CanEnter(Membership membership, DateTime date, int hour);
        

    }
}