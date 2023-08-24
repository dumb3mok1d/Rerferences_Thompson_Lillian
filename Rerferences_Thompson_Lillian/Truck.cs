using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rerferences_Thompson_Lillian
{
    internal class Truck
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        public double Weight { get; }

        public Truck( double speedParam, double weightParam, string licneseNum)
        {
            Speed = speedParam;
            Weight = weightParam;  
            LicensePlate = licneseNum;

            if(Weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        public Truck(double speed)
        {
            Wheels = 4;
            Speed = speed;
            LicensePlate = "GCTC-06";
        }

        public void Stringify()
        {
            Console.WriteLine($"the Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}. ");

        }

        public void IncreaseSpeed()
        {
            Speed += 5;

        }

        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}
