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
            public static byte _PC = 0;
            public static sbyte _AC = 0;
            public static byte _IR = 0;
            public static bool _CARRY = false;
            public static bool _OVERFLOW = false;
            public static bool _NEGATIVE = false;
            public static bool _ZERO = false;
            public static byte _DATA_BUS = 0;
            public static byte[] _MEMORY = new byte[255];
            public static string[] _INSTR =
                { "LDA","STA", "ADD", "ADDC", "SUB", "SUBC", "INC", "DEC", "AND", "OR", "INV", "XOR", "CLRA","CLRC","CSET", "CMP", "JMP","JC","JNC","JS","JNS","JZ","JNZ","JCS","JNCS","JCNS","JNCNS","JCZ","JNCZ","JCNZ","JNCNZ","JSZ","JNSZ","JSNZ","JNSNZ" };
            public static string[] _OPCODE =
                { "10000010","10100010", "01000010", "01001010", "01000010", "01011010", "01001100", "01000100", "01011010", "01011110", "01011000", "01010110", "01001111","01000000","01001000", "01001010", "11000000","11100100","11100000","11010010","11010000","11001001","11001000","11110110","11110010","11110100","11110000","11101101","11101001","11101100","11101000","11011011","11011001","11011010","11011000" };

            public static List<String> _PROGRAM_TOKENS = new List<String>();
            public static List<String> _OPCODE_ARRAY;


            public static byte[] _PROGRAM_ARRAY = new byte[255];
        }

        public class Instructions
        {
            public sbyte LDA_IMMEDIATE(sbyte ac, sbyte db) //Loads whatever is on the databus to the accumulator
            {
                Globals._PC++;
                ac = db;
                return ac;
            }

            public sbyte LDA_DIRECT(sbyte ac, sbyte db) //Loads from memory location (on the databus) to accumulator
            {
                Globals._PC++;
                ac = Convert.ToSByte(Globals._MEMORY[db]);
                return ac;
            }

            public void STA_DIRECT(sbyte ac, sbyte db)//Stores what is in the accumulator to memory location (on the databus)
            {
                Globals._PC++;
                Globals._MEMORY[db] = Convert.ToByte(ac);
            }

            public sbyte ADD_IMMEDIATE(sbyte ac, sbyte db)//
            {
                Globals._PC++;
                int temp = ac + db;
                ac = Convert.ToSByte(temp);

                return ac;
            }

            public sbyte ADD_DIRECT(sbyte ac, sbyte db)
            {
                int temp = Globals._MEMORY[db] + ac;
                ac = Convert.ToSByte(temp);

                return ac;
            }

            public sbyte ADDC_IMMEDIATE(sbyte ac, sbyte db)
            {
                Globals._PC++;
                int temp = ac + db + 1;
                ac = Convert.ToSByte(temp);


                return ac;
            }

            public sbyte ADDC_DIRECT(sbyte ac, sbyte db)
            {
                Globals._PC++;
                int temp = Globals._MEMORY[db] + ac + 1;
                ac = Convert.ToSByte(temp);

                return ac;
            }

            public sbyte SUB_IMMEDIATE(sbyte ac, sbyte db)
            {
                int temp = ac - db;
                ac = Convert.ToSByte(temp);

                return ac;
            }

            public int SUB_DIRECT(sbyte ac, sbyte db)
            {
                Globals._PC++;
                int temp = Globals._MEMORY[db] - ac;
                ac = Convert.ToSByte(temp);

                return ac;
            }

            public sbyte SUBC_IMMEDIATE(sbyte ac, sbyte db)
            {
                Globals._PC++;
                int temp = ac + db + 1;
                ac = Convert.ToSByte(temp);


                return ac;
            }

            public sbyte SUBC_DIRECT(sbyte ac, sbyte db)
            {
                Globals._PC++;
                int temp = Globals._MEMORY[db] + ac + 1;


                return ac;
            }

            public sbyte INC_INHERENT(sbyte ac)
            {
                int temp = ac + 1;
                ac = Convert.ToSByte(temp);
                return ac;
            }

            public sbyte DEC_INHERENT(sbyte ac)
            {
                Globals._PC++;
                int temp = ac - 1;
                ac = Convert.ToSByte(temp);

                return ac;
            }

            public sbyte AND_DIRECT(sbyte ac, sbyte db)
            {
                Globals._PC++;
                return (Convert.ToSByte(ac & db));
            }

            public sbyte AND_IMMEDIATE(sbyte ac, sbyte db)
            {
                Globals._PC++;
                return (Convert.ToSByte(ac & Globals._MEMORY[db]));
            }

            public sbyte OR_DIRECT(sbyte ac, sbyte db)
            {
                Globals._PC++;
                return (Convert.ToSByte(ac | db));
            }

            public sbyte OR_IMMEDIATE(sbyte ac, sbyte db)
            {
                Globals._PC++;
                return (Convert.ToSByte(ac | Globals._MEMORY[db]));
            }

            public sbyte XOR_DIRECT(sbyte ac, sbyte db)
            {
                Globals._PC++;
                return (Convert.ToSByte(ac ^ db));
            }

            public sbyte XOR_IMMEDIATE(int ac, int db)
            {
                Globals._PC++;
                return (Convert.ToSByte(ac ^ Globals._MEMORY[db]));
            }

            public sbyte INV_INHERENT(sbyte ac)
            {
                Globals._PC++;
                return (Convert.ToSByte(~ac)); //Returns bitwise complement
            }

            public sbyte CLRA_INHERENT(sbyte ac)
            {
                Globals._PC++;
                ac = 0;
                return (ac);
            }

            //public void JMP_DIRECT(int db)
            //{
            //    Globals._PC = db;
            //}

            public void JMP_DIRECT(byte db)
            {
                Globals._PC = Globals._MEMORY[db];

            }

        }

        public class Converters
        {
            public string SbyteToString(sbyte toBeConverted)
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

                if (Char.GetNumericValue(arr[7]) == 1)
                {
                    bin = Convert.ToSByte(-bin);
                }

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
