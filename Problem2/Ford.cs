using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Ford
    {
        public string Model { get; set; }
        public double Weight { get; set; }
        public int Engine { get; set; }

        public Ford()
        {
            Model = string.Empty;
            Weight = 0;
            Engine = 0;
        }
        public double CalculateMPG()
        {
            double MPG = 0;
            if (Engine == 4)
            {
                MPG = Engine * 0.0075;
            }
            else if (Engine == 6)
            {
                MPG = Engine * 0.005;
            }
            else if (Engine == 8)
            {
                MPG = Engine * 0.0035;
            }

            return MPG;
        }
    }
}
