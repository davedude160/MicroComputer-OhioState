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
            public static byte _COUNT = 0;
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
                { "LDA","STA", "ADD", "ADDC", "SUB", "SUBC", "INC", "DEC", "AND", "OR", "INV", "XOR", "CLRA","CLRC","CSET", "CMP", "JMP" };
            public static string[] _OPCODE =
                { "10000010","10100010", "01000010", "01001010", "01000010", "01011010", "01001100", "01000100", "01011010", "01011110", "01011000", "01010110", "01001111","01000000","01001000", "01001010", "11000000" };

            public static List<String> _PROGRAM_TOKENS = new List<String>();
            public static List<String> _OPCODE_ARRAY;


            public static byte[] _PROGRAM_ARRAY = new byte[255];
        }

        public class Instructions
        {
            public static sbyte LDA_IMMEDIATE(sbyte ac, sbyte db) //Loads whatever is on the databus to the accumulator
            {
                Globals._PC++;
                ac = db;
                return ac;
            }

            public static sbyte LDA_DIRECT(sbyte ac, sbyte db) //Loads from memory location (on the databus) to accumulator
            {
                Globals._PC++;
                ac = Convert.ToSByte(Globals._MEMORY[db]);
                return ac;
            }

            public static void STA_DIRECT(sbyte ac, sbyte db)//Stores what is in the accumulator to memory location (on the databus)
            {
                Globals._PC++;
                Globals._MEMORY[db] = Convert.ToByte(ac);
            }

            public static sbyte ADD_IMMEDIATE(sbyte ac, sbyte db)//
            {
                Globals._PC++;
                int temp = ac + db;
                ac = Convert.ToSByte(temp);

                return ac;
            }

            public static sbyte ADD_DIRECT(sbyte ac, sbyte db)
            {
                int temp = Globals._MEMORY[db] + ac;
                ac = Convert.ToSByte(temp);

                return ac;
            }

            public static sbyte ADDC_IMMEDIATE(sbyte ac, sbyte db)
            {
                Globals._PC++;
                int temp = ac + db + 1;
                ac = Convert.ToSByte(temp);


                return ac;
            }

            public static sbyte ADDC_DIRECT(sbyte ac, sbyte db)
            {
                Globals._PC++;
                int temp = Globals._MEMORY[db] + ac + 1;
                ac = Convert.ToSByte(temp);

                return ac;
            }

            public static sbyte SUB_IMMEDIATE(sbyte ac, sbyte db)
            {
                int temp = ac - db;
                ac = Convert.ToSByte(temp);

                return ac;
            }

            public static sbyte SUB_DIRECT(sbyte ac, sbyte db)
            {
                Globals._PC++;
                int temp = Globals._MEMORY[db] - ac;
                ac = Convert.ToSByte(temp);

                return ac;
            }

            public static sbyte SUBC_IMMEDIATE(sbyte ac, sbyte db)
            {
                Globals._PC++;
                int temp = ac + db + 1;
                ac = Convert.ToSByte(temp);


                return ac;
            }

            public static sbyte SUBC_DIRECT(sbyte ac, sbyte db)
            {
                Globals._PC++;
                int temp = Globals._MEMORY[db] + ac + 1;


                return ac;
            }

            public static sbyte INC_INHERENT(sbyte ac)
            {
                int temp = ac + 1;
                ac = Convert.ToSByte(temp);
                return ac;
            }

            public static sbyte DEC_INHERENT(sbyte ac)
            {
                Globals._PC++;
                int temp = ac - 1;
                ac = Convert.ToSByte(temp);

                return ac;
            }

            public static sbyte AND_DIRECT(sbyte ac, sbyte db)
            {
                Globals._PC++;
                return (Convert.ToSByte(ac & db));
            }

            public static sbyte AND_IMMEDIATE(sbyte ac, sbyte db)
            {
                Globals._PC++;
                return (Convert.ToSByte(ac & Globals._MEMORY[db]));
            }

            public static sbyte OR_DIRECT(sbyte ac, sbyte db)
            {
                Globals._PC++;
                return (Convert.ToSByte(ac | db));
            }

            public static sbyte OR_IMMEDIATE(sbyte ac, sbyte db)
            {
                Globals._PC++;
                return (Convert.ToSByte(ac | Globals._MEMORY[db]));
            }

            public static sbyte XOR_DIRECT(sbyte ac, sbyte db)
            {
                Globals._PC++;
                return (Convert.ToSByte(ac ^ db));
            }

            public static sbyte XOR_IMMEDIATE(int ac, int db)
            {
                Globals._PC++;
                return (Convert.ToSByte(ac ^ Globals._MEMORY[db]));
            }

            public static sbyte INV_INHERENT(sbyte ac)
            {
                Globals._PC++;
                return (Convert.ToSByte(~ac)); //Returns bitwise complement
            }

            public static sbyte CLRA_INHERENT(sbyte ac)
            {
                Globals._PC++;
                ac = 0;
                return (ac);
            }

            //public void JMP_DIRECT(int db)
            //{
            //    Globals._PC = db;
            //}

            public static void JMP_DIRECT(byte db)
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

        public static class InstructionHandler
        {
            public static void Handler(string opcode)
            {
                if (opcode == "10000010")
                {
                    Globals._AC = CPU.Instructions.LDA_IMMEDIATE(CPU.Globals._AC, Convert.ToSByte(CPU.Globals._DATA_BUS));
                }
                else if (opcode == "10000010")
                {
                    Globals._AC = CPU.Instructions.LDA_DIRECT(CPU.Globals._AC, Convert.ToSByte(CPU.Globals._DATA_BUS));
                }
                else if (opcode == "10100010")
                {
                    CPU.Instructions.STA_DIRECT(CPU.Globals._AC, Convert.ToSByte(CPU.Globals._DATA_BUS));
                }else if (opcode == "01000010")
                {
                    Globals._AC = CPU.Instructions.ADD_IMMEDIATE(CPU.Globals._AC, Convert.ToSByte(CPU.Globals._DATA_BUS));
                }
                else if (opcode == "01000001")
                {
                    Globals._AC = CPU.Instructions.ADD_DIRECT(CPU.Globals._AC, Convert.ToSByte(CPU.Globals._DATA_BUS));
                }
                else if (opcode == "01001010")
                {
                    Globals._AC = CPU.Instructions.ADDC_IMMEDIATE(CPU.Globals._AC, Convert.ToSByte(CPU.Globals._DATA_BUS));
                }
                else if (opcode == "01001001")
                {
                    Globals._AC = CPU.Instructions.ADDC_DIRECT(CPU.Globals._AC, Convert.ToSByte(CPU.Globals._DATA_BUS));
                }
                else if (opcode == "01000010")
                {
                    Globals._AC = CPU.Instructions.SUB_IMMEDIATE(CPU.Globals._AC, Convert.ToSByte(CPU.Globals._DATA_BUS));
                }
                else if (opcode == "01000001")
                {
                    Globals._AC = CPU.Instructions.SUB_DIRECT(CPU.Globals._AC, Convert.ToSByte(CPU.Globals._DATA_BUS));
                }else if (opcode == "01011010")
                {
                    Globals._AC = CPU.Instructions.SUBC_IMMEDIATE(CPU.Globals._AC, Convert.ToSByte(CPU.Globals._DATA_BUS));
                }
                else if (opcode == "01011001")
                {
                    Globals._AC = CPU.Instructions.SUBC_DIRECT(CPU.Globals._AC, Convert.ToSByte(CPU.Globals._DATA_BUS));
                }
                else if (opcode == "01001100")
                {
                    Globals._AC = CPU.Instructions.INC_INHERENT(CPU.Globals._AC);
                }
                else if (opcode == "01001100")
                {
                    Globals._AC = CPU.Instructions.DEC_INHERENT(CPU.Globals._AC);
                }
                else if (opcode == "01011010")
                {
                    Globals._AC = CPU.Instructions.AND_IMMEDIATE(CPU.Globals._AC, Convert.ToSByte(CPU.Globals._DATA_BUS));
                }
                else if (opcode == "01011001")
                {
                    Globals._AC = CPU.Instructions.AND_DIRECT(CPU.Globals._AC, Convert.ToSByte(CPU.Globals._DATA_BUS));
                }
                else if (opcode == "01011110")
                {
                    Globals._AC = CPU.Instructions.OR_IMMEDIATE(CPU.Globals._AC, Convert.ToSByte(CPU.Globals._DATA_BUS));
                }
                else if (opcode == "01011101")
                {
                    Globals._AC = CPU.Instructions.OR_DIRECT(CPU.Globals._AC, Convert.ToSByte(CPU.Globals._DATA_BUS));
                }
                else if (opcode == "01011000")
                {
                    Globals._AC = CPU.Instructions.INV_INHERENT(CPU.Globals._AC);
                }
                else if (opcode == "01010110")
                {
                    Globals._AC = CPU.Instructions.XOR_IMMEDIATE(CPU.Globals._AC, Convert.ToSByte(CPU.Globals._DATA_BUS));
                }
                else if (opcode == "01010101")
                {
                    Globals._AC = CPU.Instructions.XOR_DIRECT(CPU.Globals._AC, Convert.ToSByte(CPU.Globals._DATA_BUS));
                }
                else if (opcode == "01010110")
                {
                    Globals._AC = CPU.Instructions.CLRA_INHERENT(CPU.Globals._AC);
                }

                //case:

                //    break;
                //case "10000001": 
                //     public static string[] _INSTR =
                //    { "LDA","STA", "ADD", "ADDC", "SUB", "SUBC", "INC", "DEC", "AND", "OR", "INV", "XOR", "CLRA","CLRC","CSET", "CMP", "JMP" };
                //public static string[] _OPCODE =
                //    { "10000010","10100010", "01000010", "01001010", "01000010", "01011010", "01001100", "01000100", "01011010", !"01011110", !"01011000", !"01010110", "01001111","01000000","01001000", "01001010", "11000000" };
                //    Globals._AC = CPU.Instructions.LDA_DIRECT(Globals._AC, Convert.ToSByte(Globals._DATA_BUS));

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
