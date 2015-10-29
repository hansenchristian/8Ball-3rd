using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ownlibary
{
    public class Class1
    {
        [DllImport(@"8Ball.dll", EntryPoint = "?setAnsage@eightball@eightballdll@@SAXH@Z", CallingConvention = CallingConvention.Cdecl)]
        public static extern void setAnsageOld(int i);
        [DllImport(@"8Ball.dll", EntryPoint = "?firstHit@eightball@eightballdll@@SAHH_NPEAH@Z", CallingConvention = CallingConvention.Cdecl)]
        public static extern int firstHitOld(int count, bool hit, int[] ballsinhole);
        [DllImport(@"8Ball.dll", EntryPoint = "?stoss@eightball@eightballdll@@SAHHPEAH@Z", CallingConvention = CallingConvention.Cdecl)]
        public static extern int stossOld(int count, int[] ballsinhole);

        public static void setAnsage(int i)
        {
            setAnsageOld(i);
        }

        public static int stoss(int count, int[] ballsinhole)
        {
            return stossOld(count, ballsinhole);
        }

        public static int firstHit(int count, bool hit, int[] ballsinhole)
        {
            return firstHitOld(count, hit, ballsinhole);
        }
    }
}
