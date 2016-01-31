using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroComputer
{
    static class CPU
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static class Globals
        {
            public static int _PC = 0;
            public static int _AC = 0;
            public static int _IR = 00000000;
            public static bool _CARRY = false;
            public static bool _OVERFLOW = false;
            public static bool _NEGATIVE = false;
            public static bool _ZERO = false;
            public static int _DATA_BUS = 0;
            public static int[] _MEMORY = new int[255];

            public static string[] _INSTR =
                { "LDA","STA", "ADD", "ADDC", "SUB", "SUBC", "INC", "DEC", "AND", "OR", "INV", "XOR", "CLRA","CLRC","CSET", "CMP", "JMP" };
            public static string[] _OPCODE =
                { "10000010","10100010", "01000010", "01001010", "01000010", "01011010", "01001100", "01000100", "01011010", "01011110", "01011000", "01010110", "01001111","01000000","01001000", "01001010", "11000000" };

            public static List<String> _PROGRAM_TOKENS = new List<String>();

            public static int[] _PROGRAM_ARRAY = new int[255];
            public static int[] _OPCODE_ARRAY = new int[255];
        }

        public class Instructions
        {
            public static int LDA_IMMEDIATE(int ac, int db) //Loads whatever is on the databus to the accumulator
            {
                Globals._PC++;
                ac = db;
                return ac;
            }

            public static int LDA_DIRECT(int ac, int db) //Loads from memory location (on the databus) to accumulator
            {
                Globals._PC++;
                ac = Globals._MEMORY[db];
                return ac;
            }

            public static void STA_DIRECT(int ac, int db)//Stores what is in the accumulator to memory location (on the databus)
            {
                Globals._PC++;
                Globals._MEMORY[db] = ac;
            }

            public static int ADD_IMMEDIATE(int ac, int db)//
            {
                Globals._PC++;
                ac = ac + db;

                if (ac > 255)
                {
                    return -1; //Overflow has occured
                }

                return ac;
            }

            public static int ADD_DIRECT(int ac, int db)
            {
                ac = Globals._MEMORY[db] + ac;

                if (ac > 255)
                {
                    return -1; //Overflow has occured
                }

                return ac;
            }

            public static int ADDC_IMMEDIATE(int ac, int db)
            {
                Globals._PC++;
                ac = ac + db + 1;

                if (ac > 255)
                {
                    return -1; //Overflow has occured
                }

                return ac;
            }

            public static int ADDC_DIRECT(int ac, int db)
            {
                Globals._PC++;
                ac = Globals._MEMORY[db] + ac + 1;

                if (ac > 255)
                {
                    return -1; //Overflow has occured
                }

                return ac;
            }

            public static int SUB_IMMEDIATE(int ac, int db)
            {
                ac = ac - db;

                if (ac < -255)
                {
                    return -1; //Underflow has occured
                }

                return ac;
            }

            public static int SUB_DIRECT(int ac, int db)
            {
                Globals._PC++;
                ac = Globals._MEMORY[db] - ac;

                if (ac < -255)
                {
                    return -1; //Underflow has occured
                }

                return ac;
            }

            public static int SUBC_IMMEDIATE(int ac, int db)
            {
                Globals._PC++;
                ac = ac + db + 1;

                if (ac < -255)
                {
                    return -1; //Underflow has occured
                }

                return ac;
            }

            public static int SUBC_DIRECT(int ac, int db)
            {
                Globals._PC++;
                ac = Globals._MEMORY[db] + ac + 1;

                if (ac < -255)
                {
                    return -1; //Underflow has occured
                }

                return ac;
            }

            public static int INC_INHERENT(int ac)
            {
                ac = ac + 1;
                if (ac > 255)
                {
                    return -1; //Overflow has occured
                }
                return ac;
            }

            public static int DEC_INHERENT(int ac)
            {
                Globals._PC++;
                ac = ac - 1;

                if (ac < -255)
                {
                    return -1; //Underflow has occured
                }
                return ac;
            }

            public static int AND_DIRECT(int ac, int db)
            {
                Globals._PC++;
                return (ac & db);
            }

            public int AND_IMMEDIATE(int ac, int db)
            {
                Globals._PC++;
                return (ac & Globals._MEMORY[db]);
            }

            public static int OR_DIRECT(int ac, int db)
            {
                Globals._PC++;
                return (ac | db);
            }

            public static int OR_IMMEDIATE(int ac, int db)
            {
                Globals._PC++;
                return (ac | Globals._MEMORY[db]);
            }

            public static int XOR_DIRECT(int ac, int db)
            {
                Globals._PC++;
                return (ac ^ db);
            }

            public static int XOR_IMMEDIATE(int ac, int db)
            {
                Globals._PC++;
                return (ac ^ Globals._MEMORY[db]);
            }

            public static int INV_INHERENT(int ac)
            {
                Globals._PC++;
                return (~ac); //Returns bitwise complement
            }

            public static int CLRA_INHERENT(int ac)
            {
                Globals._PC++;
                ac = 0;
                return (ac);
            }

            public static void JMP_DIRECT(int db)
            {
                Globals._PC = db;
            }

            public static void JMP_IMMEDIATE(int db)
            {
                Globals._PC = Globals._MEMORY[db];

            }

        }

        public class IntegerToBinaryConverter
        {
            public static string converter(int toBeConverted)
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
