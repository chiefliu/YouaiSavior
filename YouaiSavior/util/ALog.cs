using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YouaiSavior.util
{
    class ALog
    {
        private const string TAG = "YouaiSaviour";
        public static bool NO_DEBUG = false;

        public static void D(string s) {
            if (NO_DEBUG) {
                return;
            }
            Console.WriteLine("D/" + TAG + ":" + s);
        }

        public static void E(string s)
        {
            if (NO_DEBUG)
            {
                return;
            }
            Console.WriteLine("E/" + TAG + ":" + s);
        }

        public static void D(string tag, string s)
        {
            if (NO_DEBUG)
            {
                return;
            }
            Console.WriteLine("D/" + tag + ":" + s);
        }

        public static void E(string tag, string s)
        {
            if (NO_DEBUG)
            {
                return;
            }
            Console.WriteLine("E/" + tag + ":" + s);
        }
    }
}
