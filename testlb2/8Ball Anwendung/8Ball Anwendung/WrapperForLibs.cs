using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using foreign = foreignlibary.Class1;
using own = ownlibary.Class1;

namespace _8Ball_Anwendung
{
    class WrapperForLibs
    {
        public int spieler = 0;
        _8Ball_Anwendung.Service1 serverservice = new Service1();

        public int first(int count, Boolean hit, int [] sinkedBalls, Boolean ownorforeign)
        {
            if(ownorforeign == true)
            {
                int retval = serverservice.first(count, hit, sinkedBalls);
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
            else
            {
                return own.firstHit(count, hit, sinkedBalls);
            }
        }

        public void ansage(int ansage, Boolean ownorforeign)
        {
            if (ownorforeign == true)
            {
                serverservice.ansage(ansage);
            }
            else
            {
                own.setAnsage(ansage);
            }

        }

        public int other(int hitBalls, int[] sinkedBalls, Boolean ownorforeign)
        {
            if (ownorforeign == true)
            {
                int retval = serverservice.other(hitBalls, sinkedBalls);
                if (retval < -200)
                {
                    spieler = (spieler + 1) % 2;
                    return 5 + spieler;
                }
                else if(retval != 1 && retval != 2)
                {
                    return 3 +  spieler;
                }
                else
                {
                    return retval;
                }
            }
            else
            {
                return own.stoss(hitBalls, sinkedBalls);
            }
        }
    }
}
