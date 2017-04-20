using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kata.Build_Tower
{
    class BuildTower
    {
        int nFloors;
        string[] tower;
        int floorLenght;

        public BuildTower(int numberOfFloors)
        {
            this.nFloors = numberOfFloors;

            tower = new string[nFloors];

            this.floorLenght = (nFloors * 2);
        }


        public string[] TowerBuilder()
        {
            for(int i = 0; i < nFloors; i++)
            {
                BuildFloor(i);
            }

            return tower;
        }

        public void PrintTower()
        {
            foreach(string floor in tower)
            {
                Console.WriteLine(floor);
            }
        }

        public string[] GetTower()
        {
            return tower;
        }

        public void BuildFloor(int floorNumber)
        {
            for(int i = 1; i < floorLenght; i++)
            {
                if(i>=(nFloors-floorNumber) && i <=(nFloors + floorNumber))
                {
                    tower[floorNumber] +='*';
                }
                else
                {
                    tower[floorNumber] +=' ';
                }
            }
        }

    }
}
