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
            public static Dictionary<string, string> _INSTRUCTION_LABELS= new Dictionary<string, string>(); 

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
                byte temp1 = (byte)ac;
                byte temp2;
                byte temp3 = (byte)0xFF;

                if (isImmediate) temp2 = (byte)db;
                else
                    temp2 = (byte)CPU.Globals._MEMORY[db];


                Globals._CARRY = (temp1 > temp3 - temp2);

                int temp4 = temp1 + temp2;

                return (sbyte)temp4;
            }
        }

        public class Instr_ADDC : Instr //TODO
        {

            public Instr_ADDC()
            {
                call = "ADDC";
                opcode = "010010";
                isJMP = false;
                isInherent = false;
            }
            public override sbyte operation(sbyte ac, sbyte db)
            {
                Globals._PC += 2;
                byte temp1 = (byte)ac;

                byte temp2;

                byte temp3 = (byte)0xFF;
                int temp4;
                if (isImmediate) temp2 = (byte)db;
                else
                    temp2 = (byte)CPU.Globals._MEMORY[db];
                if (Globals._CARRY)
                {
                    Globals._CARRY = (temp1 >= temp3 - temp2);
                    temp4 = temp1 + temp2 + 1;
                }
                else
                {
                    Globals._CARRY = (temp1 > temp3 - temp2);
                    temp4 = temp1 + temp2;
                }


                return (sbyte)temp4;
            }

        }

        public class Instr_SUB : Instr //TODO
        {
            public Instr_SUB()
            {
                call = "SUB";
                opcode = "010100";

                isJMP = false;
                isInherent = false;

            }
            public override sbyte operation(sbyte ac, sbyte db)
            {
                Globals._PC += 2;
                byte temp1 = (byte)ac;

                byte temp2;

                byte temp3 = (byte)0xFF;

                if (isImmediate) temp2 = (byte)(-db);
                else
                    temp2 = (byte)(-CPU.Globals._MEMORY[db]);

                Globals._CARRY = (temp1 <= temp3 - temp2);
                int temp4 = temp1 + temp2;

                return (sbyte)(temp4);

            }

        }

        public class Instr_SUBC : Instr //TODO
        {
            public Instr_SUBC()
            {
                call = "SUBC";
                opcode = "010110";

                isJMP = false;
                isInherent = false;

            }
            public override sbyte operation(sbyte ac, sbyte db)
            {
                Globals._PC += 2;
                byte temp1 = (byte)ac;

                byte temp2;

                byte temp3 = (byte)0xFF;
                int temp4;
                if (isImmediate) temp2 = (byte)(-db);
                else
                    temp2 = (byte)(-CPU.Globals._MEMORY[db]);
                if (Globals._CARRY)
                {
                    Globals._CARRY = (temp1 < temp3 - temp2);
                    temp4 = temp1 + temp2 - 1;
                }
                else
                {
                    Globals._CARRY = (temp1 <= temp3 - temp2);
                    temp4 = temp1 + temp2;
                }
                return (sbyte)temp4;
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
                return (sbyte)(a + 1);

            }

        }


        public class Instr_DEC : Instr //TODO
        {
            public Instr_DEC()
            {

                call = "DEC";
                opcode = "01000100";

                isJMP = false;
                isInherent = true;

            }
            public override sbyte operation(sbyte a, sbyte b)
            {
                Globals._PC++;
                return --a;
            }

        }

        public class Instr_AND : Instr //TODO
        {
            public Instr_AND()
            {
                call = "AND";
                opcode = "011000";
                isJMP = false;
                isInherent = false;

            }
            public override sbyte operation(sbyte a, sbyte b)
            {
                if (isImmediate)
                {
                    Globals._PC += 2;
                    return Convert.ToSByte(a & b);
                }
                else
                {
                    Globals._PC += 2;
                    return (sbyte)(CPU.Globals._MEMORY[b] & a);
                }

            }

        }

        public class Instr_OR : Instr //TODO
        {
            public Instr_OR()
            {

                call = "OR";
                opcode = "011100";
                isJMP = false;
                isInherent = false;

            }
            public override sbyte operation(sbyte a, sbyte b)
            {
                if (isImmediate)
                {
                    Globals._PC += 2;
                    return Convert.ToSByte(a | b);
                }
                else
                {
                    Globals._PC += 2;
                    return (sbyte)(CPU.Globals._MEMORY[b] | a);
                }
            }

        }

        public class Instr_INV : Instr //TODO
        {
            public Instr_INV()
            {
                call = "INV";
                opcode = "01100100";
                isJMP = false;
                isInherent = true;

            }
            public override sbyte operation(sbyte a, sbyte b)
            {
                Globals._PC++;
                return Convert.ToSByte(~a + 1);
            }

        }

        public class Instr_XOR : Instr //TODO
        {
            public Instr_XOR()
            {
                call = "XOR";
                opcode = "011011";
                isJMP = false;
                isInherent = false;

            }
            public override sbyte operation(sbyte a, sbyte b)
            {
                if (isImmediate)
                {
                    Globals._PC += 2;
                    return Convert.ToSByte(a ^ b);
                }
                else
                {
                    Globals._PC += 2;
                    return (sbyte)(CPU.Globals._MEMORY[b] ^ a);
                }
            }

        }

        public class Instr_CLRA : Instr //TODO
        {
            public Instr_CLRA()
            {
                call = "CLRA";
                opcode = "01110100";
                isJMP = false;
                isInherent = true;

            }
            public override sbyte operation(sbyte a, sbyte b)
            {
                Globals._PC += 1;
                return 0;
            }

        }

        public class Instr_CMP : Instr //TODO
        {
            public Instr_CMP()
            {
                call = "CMP";
                opcode = "011111";
                isJMP = false;
                isInherent = false;

            }
            public override sbyte operation(sbyte a, sbyte b)
            {
                if (isImmediate)
                {
                    Globals._PC += 2;

                    if (a < b)
                    {
                        return -1;
                    }
                    if (a > b)
                    {
                        return 1;
                    }
                    else
                        return 0;
                }
                else
                {
                    Globals._PC += 2;

                    if (a < CPU.Globals._MEMORY[b])
                    {
                        return -1;
                    }
                    if (a > CPU.Globals._MEMORY[b])
                    {
                        return 1;
                    }
                    else
                        return 0;
                }
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


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MicroBaby());

        }

    }
}