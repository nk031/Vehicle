using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class CarRace
    {
        public string CarColor;
        public int Doors;

        public void Paint(string coloroption)
        {
            CarColor = coloroption;
        }
        public int IncreaseDoors()
        {
           Doors++;
            return Doors;
           
        }




    }
}
