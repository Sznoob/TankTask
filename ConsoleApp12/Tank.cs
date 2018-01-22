using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Tank
    {
        public readonly int SpeedMax = 100;
        public string Name;
        public string Type;
        public int CrewSum;
        public float SpeedSum;
        public int CrewCount

        {
            get
            {
                return CrewSum;
            }

            set
            {
                CrewCount = value;
                {
                    if (CrewSum < 2)
                    {
                        CrewCount = 2;
                        Console.WriteLine("Min crew for a tank is 2");
                    }
                    else if (CrewCount > 6)
                    {
                        Console.WriteLine("Max crew for a tank is 6");
                    }

                }
            }
        }
        public void AccelerateTo(float gas )
        {
            SpeedSum = SpeedSum + ;
            if (SpeedSum > 95)
            {

            }                    
        }




        
        



    }
}
