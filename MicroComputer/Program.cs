using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroComputer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static class Globals
        {
            public static int PC = 0;
            public static int AC = 0;
            public static byte IR = 00000000;
            public static int DB = 0;
            public static List<int> MEMORY = new List<int>();
            public static int[] PROGRAM_ARRAY = new int[255];
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MicroBaby());

    }

    }
}
