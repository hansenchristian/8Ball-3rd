using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace foreignlibary
{
    public class Class1
    {
        [DllImport("8ball64.dll")]
        public static extern void init();
        [DllImport("8ball64.dll", EntryPoint = "reset", CallingConvention = CallingConvention.Cdecl)]
        public static extern void reset8ball();
        [DllImport("8ball64.dll", EntryPoint = "playersTurn", CallingConvention = CallingConvention.Cdecl)]
        public static extern int playersTurn8ball();
        [DllImport("8ball64.dll", EntryPoint = "playerWinningPoints", CallingConvention = CallingConvention.Cdecl)]
        public static extern int playerWinningPoints8ball(int playerID);
        [DllImport("8ball64.dll", EntryPoint = "remainingBallsOnTable", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr remainingBallsOnTable8ball();
        [DllImport("8ball64.dll", EntryPoint = "remainingBallsForPlayer", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr remainingBallsForPlayer(int playerID);
        [DllImport("8ball64.dll")]
        public static extern int kickoff(int playerID, int firstHitBall, int[] holedInBalls, int count, bool gameBallHoledIn);
        [DllImport("8ball64.dll")]
        public static extern int push(int playerID, int firstHitBall, int holedInBall, bool gameBallHoledIn, bool rightAnnouncment);

        public static Boolean ansage;
        public static int ansageBall;
        public static int playerid;
        public static int player = 1;



        public static int firstHit(int count, bool hit, int[] ballsinhole)
        {
            Boolean isgameballholedin = false;

            foreach (int ball in ballsinhole)
            {
                if (ball == 0)
                {
                    isgameballholedin = true;
                }
            }
            try
            {
                init();
                return kickoff(1, 1, ballsinhole, ballsinhole.Count(), isgameballholedin);
            }
            catch (Exception e) { Console.WriteLine(e); }
            return 0;
        }

        public static void setAnsage(int temp)
        {
            ansageBall = temp;
        }

        public static int stoss(int spieler, int count, int[] ballsinhole)
        {
            Boolean isgameballholedin = false;
            ansage = false;

            foreach (int ball in ballsinhole)
            {
                if (ball == 0)
                {
                    isgameballholedin = true;
                }
                if (ball == ansageBall)
                {
                    ansage = true;
                }
            }
            try
            {
                foreach (int ball in ballsinhole)
                {
                    int retval = push(spieler, ball, ball, isgameballholedin, ansage);
                    if (retval < -200)
                    {
                        return 3;
                    }
                    else if (retval == 1 || retval == 2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
            catch (Exception) { }
            return 0;
        }
    }
}
