using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devicesCircuitGraph
{
    public class ce
    {

        public ce() { }

        public int add(int pi1, int pi2)
        {
            int r = 0;
            if (pi1 == pi2 && pi1 == 1)
            {
                r = 1;
            }
            else
            {
                r = 0;
            }

            return r;
        }

    }
}
