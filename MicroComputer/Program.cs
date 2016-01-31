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
<<<<<<< HEAD
            public static int _PC = 0;
            public static int _AC = 0;
            public static int _IR = 00000000;
=======
            public static byte _PC = 0;
            public static sbyte _AC = 0;
            public static byte _IR = 0;
>>>>>>> origin/master
            public static bool _CARRY = false;
            public static bool _OVERFLOW = false;
            public static bool _NEGATIVE = false;
            public static bool _ZERO = false;
            public static byte _DATA_BUS = 0;
            public static byte[] _MEMORY = new byte[255];
            public static string[] _INSTR =
                { "LDA","STA", "ADD", "ADDC", "SUB", "SUBC", "INC", "DEC", "AND", "OR", "INV", "XOR", "CLRA","CLRC","CSET", "CMP", "JMP" };
            public static string[] _OPCODE =
                { "10000010","10100010", "01000010", "01001010", "01000010", "01011010", "01001100", "01000100", "01011010", "01011110", "01011000", "01010110", "01001111","01000000","01001000", "01001010", "11000000" };

            public static List<String> _PROGRAM_TOKENS = new List<String>();
            public static List<String> _OPCODE_ARRAY;


            public static byte[] _PROGRAM_ARRAY = new byte[255];
        }

        public class Instructions
        {
<<<<<<< HEAD
            public static int LDA_IMMEDIATE(int ac, int db) //Loads whatever is on the databus to the accumulator
=======
            public sbyte LDA_IMMEDIATE(sbyte ac, sbyte db) //Loads whatever is on the databus to the accumulator
>>>>>>> origin/master
            {
                Globals._PC++;
                ac = db;
                return ac;
            }

<<<<<<< HEAD
            public static int LDA_DIRECT(int ac, int db) //Loads from memory location (on the databus) to accumulator
=======
            public sbyte LDA_DIRECT(sbyte ac, sbyte db) //Loads from memory location (on the databus) to accumulator
>>>>>>> origin/master
            {
                Globals._PC++;
                ac = Convert.ToSByte(Globals._MEMORY[db]);
                return ac;
            }

<<<<<<< HEAD
            public static void STA_DIRECT(int ac, int db)//Stores what is in the accumulator to memory location (on the databus)
=======
            public void STA_DIRECT(sbyte ac, sbyte db)//Stores what is in the accumulator to memory location (on the databus)
>>>>>>> origin/master
            {
                Globals._PC++;
                Globals._MEMORY[db] = Convert.ToByte(ac);
            }

<<<<<<< HEAD
            public static int ADD_IMMEDIATE(int ac, int db)//
=======
            public sbyte ADD_IMMEDIATE(sbyte ac, sbyte db)//
>>>>>>> origin/master
            {
                Globals._PC++;
                int temp = ac + db;
                ac = Convert.ToSByte(temp);

                return ac;
            }

<<<<<<< HEAD
            public static int ADD_DIRECT(int ac, int db)
=======
            public sbyte ADD_DIRECT(sbyte ac, sbyte db)
>>>>>>> origin/master
            {
                int temp = Globals._MEMORY[db] + ac;
                ac = Convert.ToSByte(temp);

                return ac;
            }

<<<<<<< HEAD
            public static int ADDC_IMMEDIATE(int ac, int db)
=======
            public sbyte ADDC_IMMEDIATE(sbyte ac, sbyte db)
>>>>>>> origin/master
            {
                Globals._PC++;
                int temp = ac + db + 1;
                ac = Convert.ToSByte(temp);


                return ac;
            }

<<<<<<< HEAD
            public static int ADDC_DIRECT(int ac, int db)
=======
            public sbyte ADDC_DIRECT(sbyte ac, sbyte db)
>>>>>>> origin/master
            {
                Globals._PC++;
                int temp = Globals._MEMORY[db] + ac + 1;
                ac = Convert.ToSByte(temp);

                return ac;
            }

<<<<<<< HEAD
            public static int SUB_IMMEDIATE(int ac, int db)
=======
            public sbyte SUB_IMMEDIATE(sbyte ac, sbyte db)
>>>>>>> origin/master
            {
                int temp = ac - db;
                ac = Convert.ToSByte(temp);

                return ac;
            }

<<<<<<< HEAD
            public static int SUB_DIRECT(int ac, int db)
=======
            public int SUB_DIRECT(sbyte ac, sbyte db)
>>>>>>> origin/master
            {
                Globals._PC++;
                int temp = Globals._MEMORY[db] - ac;
                ac = Convert.ToSByte(temp);

                return ac;
            }

<<<<<<< HEAD
            public static int SUBC_IMMEDIATE(int ac, int db)
=======
            public sbyte SUBC_IMMEDIATE(sbyte ac, sbyte db)
>>>>>>> origin/master
            {
                Globals._PC++;
                int temp = ac + db + 1;
                ac = Convert.ToSByte(temp);


                return ac;
            }

<<<<<<< HEAD
            public static int SUBC_DIRECT(int ac, int db)
=======
            public sbyte SUBC_DIRECT(sbyte ac, sbyte db)
>>>>>>> origin/master
            {
                Globals._PC++;
                int temp = Globals._MEMORY[db] + ac + 1;


                return ac;
            }

<<<<<<< HEAD
            public static int INC_INHERENT(int ac)
=======
            public sbyte INC_INHERENT(sbyte ac)
>>>>>>> origin/master
            {
                int temp = ac + 1;
                ac = Convert.ToSByte(temp);
                return ac;
            }

<<<<<<< HEAD
            public static int DEC_INHERENT(int ac)
=======
            public sbyte DEC_INHERENT(sbyte ac)
>>>>>>> origin/master
            {
                Globals._PC++;
                int temp = ac - 1;
                ac = Convert.ToSByte(temp);

                return ac;
            }

<<<<<<< HEAD
            public static int AND_DIRECT(int ac, int db)
=======
            public sbyte AND_DIRECT(sbyte ac, sbyte db)
>>>>>>> origin/master
            {
                Globals._PC++;
                return (Convert.ToSByte(ac & db));
            }

            public sbyte AND_IMMEDIATE(sbyte ac, sbyte db)
            {
                Globals._PC++;
                return (Convert.ToSByte(ac & Globals._MEMORY[db]));
            }

<<<<<<< HEAD
            public static int OR_DIRECT(int ac, int db)
=======
            public sbyte OR_DIRECT(sbyte ac, sbyte db)
>>>>>>> origin/master
            {
                Globals._PC++;
                return (Convert.ToSByte(ac | db));
            }

<<<<<<< HEAD
            public static int OR_IMMEDIATE(int ac, int db)
=======
            public sbyte OR_IMMEDIATE(sbyte ac, sbyte db)
>>>>>>> origin/master
            {
                Globals._PC++;
                return (Convert.ToSByte(ac | Globals._MEMORY[db]));
            }

<<<<<<< HEAD
            public static int XOR_DIRECT(int ac, int db)
=======
            public sbyte XOR_DIRECT(sbyte ac, sbyte db)
>>>>>>> origin/master
            {
                Globals._PC++;
                return (Convert.ToSByte(ac ^ db));
            }

<<<<<<< HEAD
            public static int XOR_IMMEDIATE(int ac, int db)
=======
            public sbyte XOR_IMMEDIATE(int ac, int db)
>>>>>>> origin/master
            {
                Globals._PC++;
                return (Convert.ToSByte(ac ^ Globals._MEMORY[db]));
            }

<<<<<<< HEAD
            public static int INV_INHERENT(int ac)
=======
            public sbyte INV_INHERENT(sbyte ac)
>>>>>>> origin/master
            {
                Globals._PC++;
                return (Convert.ToSByte(~ac)); //Returns bitwise complement
            }

<<<<<<< HEAD
            public static int CLRA_INHERENT(int ac)
=======
            public sbyte CLRA_INHERENT(sbyte ac)
>>>>>>> origin/master
            {
                Globals._PC++;
                ac = 0;
                return (ac);
            }

<<<<<<< HEAD
            public static void JMP_DIRECT(int db)
            {
                Globals._PC = db;
            }

            public static void JMP_IMMEDIATE(int db)
=======
            //public void JMP_DIRECT(int db)
            //{
            //    Globals._PC = db;
            //}

            public void JMP_DIRECT(byte db)
>>>>>>> origin/master
            {
                Globals._PC = Globals._MEMORY[db];

            }

        }

        public class Converters
        {
<<<<<<< HEAD
            public static string converter(int toBeConverted)
=======
            public string SbyteToString(sbyte toBeConverted)
>>>>>>> origin/master
            {
                return (Convert.ToString(toBeConverted, 2).PadLeft(8, '0'));
            }

            public sbyte StringToSbyte(string toBeConverted)
            {
                char[] arr;
                sbyte bin = 0;

                arr = toBeConverted.ToCharArray(0, 7); //Converts to char array

                int i = 0;

                while (i < 6)
                {
                    if (Char.GetNumericValue(arr[i]) == 1)
                    {
                        bin = Convert.ToSByte(bin + (2 ^ i));
                    }
                }

<<<<<<< HEAD

             
=======
                if (Char.GetNumericValue(arr[7]) == 1)
                {
                    bin = Convert.ToSByte(-bin);
                }
>>>>>>> origin/master

                return (bin);
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
