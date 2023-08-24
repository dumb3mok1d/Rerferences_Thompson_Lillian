using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rerferences_Thompson_Lillian
{
    internal class Sedan : IAutomoblie
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        public Sedan(double speed)
        {
            Wheels = 4;
            Speed = speed;
            LicensePlate = "GCTC-06";
        }

        public void Stringify()
        {
            Console.WriteLine($"the Sedan is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}. ");

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
