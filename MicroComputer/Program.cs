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
            public static int _PC = 0;
            public static int _AC = 0;
            public static byte _IR = 00000000;
            public static int _DATA_BUS = 0;
            public static List<int> _MEMORY = new List<int>();
            public static int[] _PROGRAM_ARRAY = new int[255];
        }

        public class Instructions
        {
            public int ADD_IMMEDIATE(int ac, int db)
            {
                ac = ac + db;
                return ac;
            }

            public int ADD_DIRECT(int ac, int mem_loc)
            {
                ac = Globals._MEMORY[mem_loc] + ac;
                return ac;
            }
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
