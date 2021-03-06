﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using own = ownlibary.Class1;
using System.ServiceModel;


namespace _8Ball_Anwendung
{
    class WrapperForLibs
    {
        public int spieler = 0;

        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

        public int first(int count, Boolean hit, int [] sinkedBalls, Boolean ownorforeign)
        {
            if(ownorforeign == true)
            {
                int retval = client.first(count, hit, sinkedBalls);
                if (sinkedBalls.Contains(8))
                {
                    spieler = (spieler + 1) % 2;
                    return spieler;
                }
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
                client.ansage(ansage);
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
                int retval = client.other(hitBalls, sinkedBalls);
                if (sinkedBalls.Contains(8))
                {
                    spieler = (spieler + 1) % 2;
                    return spieler;
                }
                if (retval < -200)
                {
                    spieler = (spieler + 1) % 2;
                    return 5 + spieler;
                }
                else if(retval != 1 && retval != 2)
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
                return own.stoss(hitBalls, sinkedBalls);
            }
        }
    }
}
