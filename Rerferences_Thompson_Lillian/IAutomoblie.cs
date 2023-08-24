using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rerferences_Thompson_Lillian
{
    internal interface IAutomoblie
    {
        public double Speed { get; }

        public int Wheels { get; }

        public string LicensePlate { get; }

        public void Stringify();
    }
}
