﻿using System;
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
            public int LDA_IMMEDIATE(int ac, int db) //Loads whatever is on the databus to the accumulator
            {
                ac = db;
                return ac;
            }

            public int LDA_DIRECT(int ac, int db) //Loads from memory location (on the databus) to accumulator
            {
                ac = Globals._MEMORY[db];
                return ac;
            }

            public void STA_DIRECT(int ac, int db)//Stores what is in the accumulator to memory location (on the databus)
            {
                Globals._MEMORY[db] = ac;
            }

            public int ADD_IMMEDIATE(int ac, int db)
            {
                ac = ac + db;

                if(ac > 255)
                {
                    return -1; //Overflow has occured
                }

                return ac;
            }

            public int ADD_DIRECT(int ac, int db)
            {
                ac = Globals._MEMORY[db] + ac;

                if (ac > 255)
                {
                    return -1; //Overflow has occured
                }

                return ac;
            }

            public int ADDC_IMMEDIATE(int ac, int db)
            {
                ac = ac + db + 1;

                if (ac > 255)
                {
                    return -1; //Overflow has occured
                }

                return ac;
            }

            public int ADDC_DIRECT(int ac, int db)
            {
                ac = Globals._MEMORY[db] + ac + 1;

                if (ac > 255)
                {
                    return -1; //Overflow has occured
                }

                return ac;
            }

            public int SUB_IMMEDIATE(int ac, int db)
            {
                ac = ac - db;

                if (ac < -255)
                {
                    return -1; //Underflow has occured
                }

                return ac;
            }

            public int SUB_DIRECT(int ac, int db)
            {
                ac = Globals._MEMORY[db] - ac;

                if (ac < -255)
                {
                    return -1; //Underflow has occured
                }

                return ac;
            }

            public int SUBC_IMMEDIATE(int ac, int db)
            {
                ac = ac + db + 1;

                if (ac < -255)
                {
                    return -1; //Underflow has occured
                }

                return ac;
            }

            public int SUBC_DIRECT(int ac, int db)
            {
                ac = Globals._MEMORY[db] + ac + 1;

                if (ac < -255)
                {
                    return -1; //Underflow has occured
                }

                return ac;
            }

            public int INC_INHERENT(int ac)
            {
                ac = ac + 1;
                if (ac > 255)
                {
                    return -1; //Overflow has occured
                }
                return ac;
            }

            public int DEC_INHERENT(int ac)
            {
                ac = ac - 1;

                if (ac < -255)
                {
                    return -1; //Underflow has occured
                }
                return ac;
            }

            public int AND_DIRECT(int ac, int db)
            {
                return (ac & db);
            }

            public int AND_IMMEDIATE(int ac, int db)
            {
                return (ac & Globals._MEMORY[db]);
            }

            public int OR_DIRECT(int ac, int db)
            {
                return (ac | db);
            }

            public int OR_IMMEDIATE(int ac, int db)
            {
                return (ac | Globals._MEMORY[db]);
            }

            public int XOR_DIRECT(int ac, int db)
            {
                return (ac ^ db);
            }

            public int XOR_IMMEDIATE(int ac, int db)
            {
                return (ac ^ Globals._MEMORY[db]);
            }

            public int INV_INHERENT(int ac)
            {
                return (~ac); //Returns bitwise complement
            }

            public int CLRA_INHERENT(int ac)
            {
                ac = 0;
                return (ac);
            }

        }

        public class IntegerToBinaryConverter
        {
            public string converter(int toBeConverted)
            {
                return (Convert.ToString(toBeConverted, 2));
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
