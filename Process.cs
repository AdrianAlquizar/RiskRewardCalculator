using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Risk_Reward_Calculator
{
    internal class Process
    {
        public double entryP, exitP, StopL;
        public double ee, es, risreward;
        public double r1 , r2 ;

        public double Calculation()
        { 
            ee = exitP - entryP;
            es = entryP - StopL;

            risreward = ee / es;
            

            return risreward;
        }
        
        public double Ratio1()
        {
            r1 = ee / es;

            return r1;
        }
        public double Ratio2()
        {
            r2 = es / es;

            return r2;
        }

    }
}
