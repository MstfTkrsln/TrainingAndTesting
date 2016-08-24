using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CarBuild
{
    public class BmwBuilding:ICar
    {
        public const string carname = "BMW";
        
        private int door;
        private ConsoleColor _color;
        public void Body()
        {
            
            Console.WriteLine("Body Completed");
        }

        public void Doors(int countOfDoor)
        {
            door = countOfDoor;
            Console.WriteLine(countOfDoor +" Door Completed");
        }

        public void Brush(ConsoleColor color)
        {
            _color = color;
            Console.WriteLine(color +" Brushed");
        }

        public void Tyres()
        {
            Console.WriteLine("Inserted Tyres");
        }

        public override string ToString()
        {
            return carname + " Door:" + door + "  Color:" + _color+"  Created...";
        }
    }

}
