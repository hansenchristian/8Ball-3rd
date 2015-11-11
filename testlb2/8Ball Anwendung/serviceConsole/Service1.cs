using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using foreign = foreignlibary.Class1;

namespace serviceConsole
{
    public class Service1 : IService1
    {
        public int spieler = 0;
        public void ansage(int ansage)
        {
            foreign.setAnsage(ansage);
        }

        public int first(int count, bool hit, int[] sinkedBalls)
        {
            int retval = foreign.firstHit(count, hit, sinkedBalls);
            if (retval < -200)
            {
                spieler = (spieler + 1) % 2;
                return 5 + spieler;
            }
            else if (retval != 1 && retval != 2)
            {
                return 3 + spieler;
            }
            else
            {
                return retval;
            }
        }

        public int other(int hitBalls, int[] sinkedBalls)
        {
            int retval = foreign.stoss(spieler, hitBalls, sinkedBalls);
            if (retval < -200)
            {
                spieler = (spieler + 1) % 2;
                return 5 + spieler;
            }
            else if (retval != 1 && retval != 2)
            {
                return 3 + spieler;
            }
            else
            {
                return retval;
            }
        }
    }
}
