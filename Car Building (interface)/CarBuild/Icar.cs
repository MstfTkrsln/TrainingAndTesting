using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CarBuild
{
    
        public interface ICar
        {
            
            void Body();
            void Doors(int countOfDoor);
            void Brush(ConsoleColor color);
            void Tyres();
            
        }

    public enum Cars
    {
        Bmw=0,
        Mercedes,
        Audi,
        Renault,
        Skoda,
        Pevgeot,
        Fiat,
        Volkswagen
    }
}

