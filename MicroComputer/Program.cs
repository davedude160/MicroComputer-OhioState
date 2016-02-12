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
            public static int _INSTR_PC = 0;
            public static sbyte _AC = 0;
            public static byte _IR = 0;
            public static bool _CARRY = false;
            public static bool _OVERFLOW = false;
            public static bool _NEGATIVE = false;
            public static bool _ZERO = false;
            public static byte _DATA_BUS = 0;
            public static sbyte[] _MEMORY = new sbyte[256];
            public static string[] _INSTR =
                { "LDA","STA", "ADD", "ADDC", "SUB", "SUBC", "INC", "DEC", "AND", "OR", "INV", "XOR", "CLRA", "CMP", "JMP","JC","JNC","JS","JNS","JZ","JNZ","JCS","JNCS","JCNS","JNCNS","JCZ","JNCZ","JCNZ","JNCNZ","JSZ","JNSZ","JSNZ","JNSNZ" };
            public static string[] _OPCODE =
                { "10000010","10100010", "01000010", "01001010", "01000010", "01011010", "01001100", "01000100", "01011010", "01011110", "01011000", "01010110", "01001111","01000000","01001000", "01001010", "11000000","11100100","11100000","11010010","11010000","11001001","11001000","11110110","11110010","11110100","11110000","11101101","11101001","11101100","11101000","11011011","11011001","11011010","11011000" };

            public static List<String> _PROGRAM_TOKENS = new List<String>();
            public static List<String> _OPCODE_ARRAY = new List<String>();
            public static List<Instr> _INSTRUCTION_ARRAY = new List<Instr>();

            public static byte[] _PROGRAM_ARRAY = new byte[256];
            public static bool runflag;


        }


        public abstract class Instr
        {
            public string call;
            public string opcode;
            public string data;
            public Byte dataopcode;
            public Boolean isImmediate;
            public Boolean isInherent;
            public Boolean isJMP;

            public Instr()
            {
            }
            public abstract sbyte operation(sbyte a, sbyte b);

        }


        public class Instr_ADD : Instr
        {

            public Instr_ADD()
            {
                call = "ADD";
                opcode = "010000";
                isJMP = false;
                isInherent = false;
            }
            public override sbyte operation(sbyte ac, sbyte db)
            {
                Globals._PC += 2;
                int temp1 = ac;
                int temp2 = db;


                if (isImmediate)
                {
                    while (temp1 != 0)
                    {
                        int c = temp1 & temp2;
                        System.Console.WriteLine("C = " + c);
                        temp2 = temp1 ^ temp2;
                        temp1 = c << 1;

                    }

                    return Convert.ToSByte(temp2);
                }
                else
                {
                    return ac = CPU.Globals._MEMORY[db];
                }

            }
        }

        public class Instr_ADDC : Instr //TODO
        {

            public Instr_ADDC()
            {
                call = "ADD";
                opcode = "010010";
                isJMP = false;
                isInherent = false;
            }
            public override sbyte operation(sbyte ac, sbyte db)
            {
                Globals._PC += 2;
                int temp1 = ac;
                int temp2 = db;


                if (isImmediate)
                {
                    while (temp1 != 0)
                    {
                        int c = temp1 & temp2;
                        System.Console.WriteLine("C = " + c);
                        temp2 = temp1 ^ temp2;
                        temp1 = c << 1;

                    }

                    return Convert.ToSByte(temp2);
                }
                else
                {
                    return ac = CPU.Globals._MEMORY[db];
                }

            }
        }

        public class Instr_SUB : Instr //TODO
        {
            public Instr_SUB()
            {
                call = "SUB";
                opcode = "010011";
                isJMP = false;
                isInherent = true;

            }
            public override sbyte operation(sbyte a, sbyte b)
            {
                return a;
            }

        }

        public class Instr_SUBC : Instr //TODO
        {
            public Instr_SUBC()
            {
                call = "SUB";
                opcode = "010011";
                isJMP = false;
                isInherent = true;

            }
            public override sbyte operation(sbyte a, sbyte b)
            {
                return a;
            }

        }

        public class Instr_LDA : Instr
        {

            public Instr_LDA()
            {
                call = "LDA";
                opcode = "100000";
                isJMP = false;
                isInherent = false;
            }
            public override sbyte operation(sbyte ac, sbyte db)
            {
                Globals._PC += 2;

                ac = db;

                if (isImmediate) ac = db;
                else ac = Globals._MEMORY[db];
                return ac;
            }
        }

        public class Instr_STA : Instr //TODO
        {

            public Instr_STA()
            {
                call = "STA";
                opcode = "101000";
                isJMP = false;
                isInherent = false;
            }
            public override sbyte operation(sbyte ac, sbyte db)
            {
                Globals._PC += 2;

                Globals._MEMORY[db] = ac;

                return 1;
            }
        }



        public class Instr_INC : Instr
        {
            public Instr_INC()
            {
                call = "INC";
                opcode = "01001100";
                isJMP = false;
                isInherent = true;

            }
            public override sbyte operation(sbyte a, sbyte b)
            {
                Globals._PC++;              
                return ++a;
            }

        }


        public class Instr_DEC : Instr //TODO
        {
            public Instr_DEC()
            {
                call = "DEC";
                opcode = "01001100";
                isJMP = false;
                isInherent = true;

            }
            public override sbyte operation(sbyte a, sbyte b)
            {
                return a;
            }

        }

        public class Instr_AND : Instr //TODO
        {
            public Instr_AND()
            {
                call = "INC";
                opcode = "01001100";
                isJMP = false;
                isInherent = false;

            }
            public override sbyte operation(sbyte a, sbyte b)
            {
                return a;
            }

        }

        public class Instr_OR : Instr //TODO
        {
            public Instr_OR()
            {
                call = "OR";
                opcode = "01001100";
                isJMP = false;
                isInherent = false;

            }
            public override sbyte operation(sbyte a, sbyte b)
            {
                return a;
            }

        }

        public class Instr_INV : Instr //TODO
        {
            public Instr_INV()
            {
                call = "INV";
                opcode = "01001100";
                isJMP = false;
                isInherent = true;

            }
            public override sbyte operation(sbyte a, sbyte b)
            {
                return a;
            }

        }

        public class Instr_XOR : Instr //TODO
        {
            public Instr_XOR()
            {
                call = "XOR";
                opcode = "01001100";
                isJMP = false;
                isInherent = true;

            }
            public override sbyte operation(sbyte a, sbyte b)
            {
                return a;
            }

        }

        public class Instr_CLRA : Instr //TODO
        {
            public Instr_CLRA()
            {
                call = "CLRA";
                opcode = "01001100";
                isJMP = false;
                isInherent = true;

            }
            public override sbyte operation(sbyte a, sbyte b)
            {
                return a;
            }

        }

        public class Instr_CMP : Instr //TODO
        {
            public Instr_CMP()
            {
                call = "CMP";
                opcode = "01001100";
                isJMP = false;
                isInherent = true;

            }
            public override sbyte operation(sbyte a, sbyte b)
            {
                return a;
            }

        }


        public class Instr_JMP : Instr
        {
            public Instr_JMP()
            {
                call = "JMP";
                opcode = "11000000";
                isJMP = true;
                isInherent = false;

            }
            public override sbyte operation(sbyte a, sbyte b)
            {
                return a;
            }



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
                Globals._MEMORY[db] = Convert.ToSByte(ac);
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
                Globals._PC = (byte)Globals._MEMORY[db];

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