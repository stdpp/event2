using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace screen
{
    class VentilatorConfig
    {
        public int tA, tB, tC, tD, tE, tF;
        public int LA, LB, LC, LD;
        public int md, sp;

        public VentilatorConfig()
        {
            tA = 10;
            tB = 20;
            tC = 30;
            tD = 60;
            tE = 70;
            tF = 100;

            LA = 40;
            LB = 120;
            LC = 120;
            LD = 40;

            md = 1;
            sp = 32;
        }
    }
}
