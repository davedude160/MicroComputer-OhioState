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
            public static sbyte _IR = 0;
            public static bool _CARRY = false;
            public static bool _OVERFLOW = false;
            public static bool _NEGATIVE = false;
            public static bool _ZERO = false;
            public static byte _DATA_BUS = 0;
            public static sbyte[] _MEMORY = new sbyte[256];
            public static string[] _INSTR =
                { "LDA","STA", "ADD", "ADDC", "SUB", "SUBC", "INC", "DEC", "AND", "OR", "INV", "XOR", "CLRA", "CMP", "JMP","JC","JNC","JN","JNN","JZ","JNZ","JCN","JNCN","JCNN","JNCNN","JCZ","JNCZ","JCNZ","JNCNZ","JZN","JNZN","JZNN","JNZNN" };
            public static string[] _OPCODE =
                { "10000010","10100010", "01000010", "01001010", "01000010", "01011010", "01001100", "01000100", "01011010", "01011110", "01011000", "01010110", "01001111","01000000","01001000", "01001010", "11000000","11100100","11100000","11010010","11010000","11001001","11001000","11110110","11110010","11110100","11110000","11101101","11101001","11101100","11101000","11011011","11011001","11011010","11011000" };

            public static List<String> _PROGRAM_TOKENS = new List<String>();
            public static List<String> _OPCODE_ARRAY = new List<String>();
            public static List<Instr> _INSTRUCTION_ARRAY = new List<Instr>();
            public static Dictionary<string, string> _INSTRUCTION_LABELS = new Dictionary<string, string>();
            public static Dictionary<int, int> _INSTR_PC_LOOKUP = new Dictionary<int, int>();
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

            public static int Directcount;
            public Instr()
            {
            }
            public abstract void operation(sbyte a, sbyte b);

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
            public override void operation(sbyte ac, sbyte db)
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

                CPU.Globals._AC = (sbyte)temp4;
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
            public override void operation(sbyte ac, sbyte db)
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


                CPU.Globals._AC = (sbyte)temp4;
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
            public override void operation(sbyte ac, sbyte db)
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

                CPU.Globals._AC = (sbyte)(temp4);

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
            public override void operation(sbyte ac, sbyte db)
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
                CPU.Globals._AC = (sbyte)temp4;
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
            public override void operation(sbyte ac, sbyte db)
            {
                Globals._PC += 2;

                if (isImmediate) ac = db;
                else ac = Globals._MEMORY[db];
                CPU.Globals._AC = ac;
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
            public override void operation(sbyte ac, sbyte db)
            {
                Globals._PC += 2;
                Globals._MEMORY[db] = ac;

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
            public override void operation(sbyte a, sbyte b)
            {


                Globals._PC++;
                CPU.Globals._AC = (sbyte)(a + 1);

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
            public override void operation(sbyte a, sbyte b)
            {
                Globals._PC++;
                CPU.Globals._AC = --a;
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
            public override void operation(sbyte a, sbyte b)
            {
                if (isImmediate)
                {
                    Globals._PC += 2;
                    CPU.Globals._AC = Convert.ToSByte(a & b);
                }
                else
                {
                    Globals._PC += 2;
                    CPU.Globals._AC = (sbyte)(CPU.Globals._MEMORY[(byte)b] & a);
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
            public override void operation(sbyte a, sbyte b)
            {
                if (isImmediate)
                {
                    Globals._PC += 2;
                    CPU.Globals._AC = Convert.ToSByte(a | b);
                }
                else
                {
                    Globals._PC += 2;
                    CPU.Globals._AC = (sbyte)(CPU.Globals._MEMORY[(byte)b] | a);
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
            public override void operation(sbyte a, sbyte b)
            {
                Globals._PC++;
                CPU.Globals._AC = Convert.ToSByte(~a + 1);
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
            public override void operation(sbyte a, sbyte b)
            {
                if (isImmediate)
                {
                    Globals._PC += 2;
                    CPU.Globals._AC = Convert.ToSByte(a ^ b);
                }
                else
                {
                    Globals._PC += 2;
                    CPU.Globals._AC = (sbyte)(CPU.Globals._MEMORY[(byte)b] ^ a);
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
            public override void operation(sbyte a, sbyte b)
            {
                Globals._PC += 1;
                CPU.Globals._AC = 0;
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
            public override void operation(sbyte a, sbyte b)
            {
                Globals._PC += 2;

                if (isImmediate)
                    CPU.Globals._AC = (sbyte)a.CompareTo(b);
                else
                    CPU.Globals._AC = (sbyte)a.CompareTo(CPU.Globals._MEMORY[(byte)b]);
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
            public override void operation(sbyte a, sbyte b)
            {
                CPU.Globals._PC = (byte)(b);
                CPU.Globals._INSTR_PC = CPU.Globals._INSTR_PC_LOOKUP[b];
            }

        }
        public class Instr_JC : Instr
        {
            public Instr_JC()
            {
                call = "JC";
                opcode = "11100100";
                isJMP = true;
                isInherent = false;

            }
            public override void operation(sbyte a, sbyte b)
            {

                if (CPU.Globals._CARRY)
                {
                    CPU.Globals._PC = (byte)(b);
                    CPU.Globals._INSTR_PC = CPU.Globals._INSTR_PC_LOOKUP[b];
                }
                else
                {
                    CPU.Globals._PC += 2;
                    CPU.Globals._INSTR_PC++;
                }
            }

        }
        public class Instr_JNC : Instr
        {
            public Instr_JNC()
            {
                call = "JNC";
                opcode = "11100000";
                isJMP = true;
                isInherent = false;

            }
            public override void operation(sbyte a, sbyte b)
            {
                if (!CPU.Globals._CARRY)
                {
                    CPU.Globals._PC = (byte)(b);
                    CPU.Globals._INSTR_PC = CPU.Globals._INSTR_PC_LOOKUP[b];
                }
                else
                {
                    CPU.Globals._PC += 2;
                    CPU.Globals._INSTR_PC++;
                }
            }

        }
        public class Instr_JN : Instr
        {
            public Instr_JN()
            {
                call = "JN";
                opcode = "11010010";
                isJMP = true;
                isInherent = false;

            }
            public override void operation(sbyte a, sbyte b)
            {
                if (!CPU.Globals._NEGATIVE)
                {
                    CPU.Globals._PC = (byte)(b);
                    CPU.Globals._INSTR_PC = CPU.Globals._INSTR_PC_LOOKUP[b];
                }
                else
                {
                    CPU.Globals._PC += 2;
                    CPU.Globals._INSTR_PC++;
                }
            }

        }
        public class Instr_JNN : Instr
        {
            public Instr_JNN()
            {
                call = "JNN";
                opcode = "11010000";
                isJMP = true;
                isInherent = false;

            }
            public override void operation(sbyte a, sbyte b)
            {
                if (CPU.Globals._NEGATIVE)
                {
                    CPU.Globals._PC = (byte)(b);
                    CPU.Globals._INSTR_PC = CPU.Globals._INSTR_PC_LOOKUP[b];
                }
                else
                {
                    CPU.Globals._PC += 2;
                    CPU.Globals._INSTR_PC++;
                }
            }

        }

        public class Instr_JZ : Instr
        {
            public Instr_JZ()
            {
                call = "JZ";
                opcode = "11001001";
                isJMP = true;
                isInherent = false;

            }
            public override void operation(sbyte a, sbyte b)
            {
                if (CPU.Globals._ZERO)
                {
                    CPU.Globals._PC = (byte)(b);
                    CPU.Globals._INSTR_PC = CPU.Globals._INSTR_PC_LOOKUP[b];
                }
                else
                {
                    CPU.Globals._PC += 2;
                    CPU.Globals._INSTR_PC++;
                }
            }

        }
        public class Instr_JNZ : Instr
        {
            public Instr_JNZ()
            {
                call = "JNZ";
                opcode = "11001000";
                isJMP = true;
                isInherent = false;

            }
            public override void operation(sbyte a, sbyte b)
            {
                if (!CPU.Globals._ZERO)
                {
                    CPU.Globals._PC = (byte)(b);
                    CPU.Globals._INSTR_PC = CPU.Globals._INSTR_PC_LOOKUP[b];
                }
                else
                {
                    CPU.Globals._PC += 2;
                    CPU.Globals._INSTR_PC++;
                }
            }

        }

        public class Instr_JCN : Instr
        {
            public Instr_JCN()
            {
                call = "JCN";
                opcode = "11110110";
                isJMP = true;
                isInherent = false;

            }
            public override void operation(sbyte a, sbyte b)
            {
                if (CPU.Globals._CARRY || CPU.Globals._NEGATIVE)
                {
                    CPU.Globals._PC = (byte)(b);
                    CPU.Globals._INSTR_PC = CPU.Globals._INSTR_PC_LOOKUP[b];
                }
                else
                {
                    CPU.Globals._PC += 2;
                    CPU.Globals._INSTR_PC++;
                }
            }
        }
        public class Instr_JNCN : Instr
        {
            public Instr_JNCN()
            {
                call = "JNCN";
                opcode = "11110010";
                isJMP = true;
                isInherent = false;

            }
            public override void operation(sbyte a, sbyte b)
            {
                if (!CPU.Globals._CARRY || CPU.Globals._NEGATIVE)
                {
                    CPU.Globals._PC = (byte)(b);
                    CPU.Globals._INSTR_PC = CPU.Globals._INSTR_PC_LOOKUP[b];
                }
                else
                {
                    CPU.Globals._PC += 2;
                    CPU.Globals._INSTR_PC++;
                }
            }

        }
        public class Instr_JCNN : Instr
        {
            public Instr_JCNN()
            {
                call = "JCNN";
                opcode = "11110100";
                isJMP = true;
                isInherent = false;

            }
            public override void operation(sbyte a, sbyte b)
            {
                if (CPU.Globals._CARRY || !CPU.Globals._NEGATIVE)
                {
                    CPU.Globals._PC = (byte)(b);
                    CPU.Globals._INSTR_PC = CPU.Globals._INSTR_PC_LOOKUP[b];
                }
                else
                {
                    CPU.Globals._PC += 2;
                    CPU.Globals._INSTR_PC++;
                }
            }

        }
        public class Instr_JNCNN : Instr
        {
            public Instr_JNCNN()
            {
                call = "JNCNN";
                opcode = "11110000";
                isJMP = true;
                isInherent = false;

            }
            public override void operation(sbyte a, sbyte b)
            {
                if (!CPU.Globals._CARRY || !CPU.Globals._NEGATIVE)
                {
                    CPU.Globals._PC = (byte)(b);
                    CPU.Globals._INSTR_PC = CPU.Globals._INSTR_PC_LOOKUP[b];
                }
                else
                {
                    CPU.Globals._PC += 2;
                    CPU.Globals._INSTR_PC++;
                }
            }

        }

        public class Instr_JCZ : Instr
        {
            public Instr_JCZ()
            {
                call = "JCZ";
                opcode = "11101101";
                isJMP = true;
                isInherent = false;

            }
            public override void operation(sbyte a, sbyte b)
            {
                if (CPU.Globals._CARRY || CPU.Globals._ZERO)
                {
                    CPU.Globals._PC = (byte)(b);
                    CPU.Globals._INSTR_PC = CPU.Globals._INSTR_PC_LOOKUP[b];
                }
                else
                {
                    CPU.Globals._PC += 2;
                    CPU.Globals._INSTR_PC++;
                }
            }

        }
        public class Instr_JNCZ : Instr
        {
            public Instr_JNCZ()
            {
                call = "JNCZ";
                opcode = "11101001";
                isJMP = true;
                isInherent = false;

            }
            public override void operation(sbyte a, sbyte b)
            {
                if (!CPU.Globals._CARRY || CPU.Globals._ZERO)
                {
                    CPU.Globals._PC = (byte)(b);
                    CPU.Globals._INSTR_PC = CPU.Globals._INSTR_PC_LOOKUP[b];
                }
                else
                {
                    CPU.Globals._PC += 2;
                    CPU.Globals._INSTR_PC++;
                }
            }

        }
        public class Instr_JCNZ : Instr
        {
            public Instr_JCNZ()
            {
                call = "JCNZ";
                opcode = "11101100";
                isJMP = true;
                isInherent = false;

            }
            public override void operation(sbyte a, sbyte b)
            {
                if (CPU.Globals._CARRY || !CPU.Globals._ZERO)
                {
                    CPU.Globals._PC = (byte)(b);
                    CPU.Globals._INSTR_PC = CPU.Globals._INSTR_PC_LOOKUP[b];
                }
                else
                {
                    CPU.Globals._PC += 2;
                    CPU.Globals._INSTR_PC++;
                }
            }

        }
        public class Instr_JNCNZ : Instr
        {
            public Instr_JNCNZ()
            {
                call = "JNCNZ";
                opcode = "11101000";
                isJMP = true;
                isInherent = false;

            }
            public override void operation(sbyte a, sbyte b)
            {
                if (!CPU.Globals._CARRY || !CPU.Globals._ZERO)
                {
                    CPU.Globals._PC = (byte)(b);
                    CPU.Globals._INSTR_PC = CPU.Globals._INSTR_PC_LOOKUP[b];
                }
                else
                {
                    CPU.Globals._PC += 2;
                    CPU.Globals._INSTR_PC++;
                }
            }

        }
        public class Instr_JZN : Instr
        {
            public Instr_JZN()
            {
                call = "JZN";
                opcode = "11011011";
                isJMP = true;
                isInherent = false;

            }
            public override void operation(sbyte a, sbyte b)
            {
                if (CPU.Globals._NEGATIVE || CPU.Globals._ZERO)
                {
                    CPU.Globals._PC = (byte)(b);
                    CPU.Globals._INSTR_PC = CPU.Globals._INSTR_PC_LOOKUP[b];
                }
                else
                {
                    CPU.Globals._PC += 2;
                    CPU.Globals._INSTR_PC++;
                }
            }

        }
        public class Instr_JNZN : Instr
        {
            public Instr_JNZN()
            {
                call = "JNZN";
                opcode = "11011001";
                isJMP = true;
                isInherent = false;

            }
            public override void operation(sbyte a, sbyte b)
            {
                if (CPU.Globals._NEGATIVE || !CPU.Globals._ZERO)
                {
                    CPU.Globals._PC = (byte)(b);
                    CPU.Globals._INSTR_PC = CPU.Globals._INSTR_PC_LOOKUP[b];
                }
                else
                {
                    CPU.Globals._PC += 2;
                    CPU.Globals._INSTR_PC++;
                }
            }

        }
        public class Instr_JZNN : Instr
        {
            public Instr_JZNN()
            {
                call = "JZNN";
                opcode = "11011010";
                isJMP = true;
                isInherent = false;

            }
            public override void operation(sbyte a, sbyte b)
            {
                if (!CPU.Globals._NEGATIVE || CPU.Globals._ZERO)
                {
                    CPU.Globals._PC = (byte)(b);
                    CPU.Globals._INSTR_PC = CPU.Globals._INSTR_PC_LOOKUP[b];
                }
                else
                {
                    CPU.Globals._PC += 2;
                    CPU.Globals._INSTR_PC++;
                }
            }

        }

        public class Instr_JNZNN : Instr
        {
            public Instr_JNZNN()
            {
                call = "JNZNN";
                opcode = "11011000";
                isJMP = true;
                isInherent = false;

            }
            public override void operation(sbyte a, sbyte b)
            {
                if (!CPU.Globals._NEGATIVE || !CPU.Globals._ZERO)
                {
                    CPU.Globals._PC = (byte)(b);
                    CPU.Globals._INSTR_PC = CPU.Globals._INSTR_PC_LOOKUP[b];
                }
                else
                {
                    CPU.Globals._PC += 2;
                    CPU.Globals._INSTR_PC++;
                }
            }

        }

        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MicroBaby());
           //comment above to test


            test.testAdd();
            test.testAddc();
            test.testSub();
            test.testSubc();
            test.testInc();
            test.testDec();


            /*
            test.testAnd();
            test.testOr();
            test.testXOr();
            test.testInv();
            test.testCmp();
            test.testClra();
              */
        }

    }
}
/*
   0    +    0    =    0   C=    0
   0    +    1    =    1   C=    0
   0    +  127    =  127   C=    0
   0    + -128    = -128   C=    0
   0    + -127    = -127   C=    0
   0    +   -1    =   -1   C=    0
   1    +    0    =    1   C=    0
   1    +    1    =    2   C=    0
   1    +  127    = -128   C=    0
   1    + -128    = -127   C=    0
   1    + -127    = -126   C=    0
   1    +   -1    =    0   C=    1
 127    +    0    =  127   C=    0
 127    +    1    = -128   C=    0
 127    +  127    =   -2   C=    0
 127    + -128    =   -1   C=    0
 127    + -127    =    0   C=    1
 127    +   -1    =  126   C=    1
-128    +    0    = -128   C=    0
-128    +    1    = -127   C=    0
-128    +  127    =   -1   C=    0
-128    + -128    =    0   C=    1
-128    + -127    =    1   C=    1
-128    +   -1    =  127   C=    1
-127    +    0    = -127   C=    0
-127    +    1    = -126   C=    0
-127    +  127    =    0   C=    1
-127    + -128    =    1   C=    1
-127    + -127    =    2   C=    1
-127    +   -1    = -128   C=    1
  -1    +    0    =   -1   C=    0
  -1    +    1    =    0   C=    1
  -1    +  127    =  126   C=    1
  -1    + -128    =  127   C=    1
  -1    + -127    = -128   C=    1
  -1    +   -1    =   -2   C=    1
   0    +    0    +    0    =    0       C=    0
   0    +    1    +    0    =    1       C=    0
   0    +  127    +    0    =  127       C=    0
   0    + -128    +    0    = -128       C=    0
   0    + -127    +    0    = -127       C=    0
   0    +   -1    +    0    =   -1       C=    0
   1    +    0    +    0    =    1       C=    0
   1    +    1    +    0    =    2       C=    0
   1    +  127    +    0    = -128       C=    0
   1    + -128    +    0    = -127       C=    0
   1    + -127    +    0    = -126       C=    0
   1    +   -1    +    0    =    0       C=    1
 127    +    0    +    0    =  127       C=    0
 127    +    1    +    0    = -128       C=    0
 127    +  127    +    0    =   -2       C=    0
 127    + -128    +    0    =   -1       C=    0
 127    + -127    +    0    =    0       C=    1
 127    +   -1    +    0    =  126       C=    1
-128    +    0    +    0    = -128       C=    0
-128    +    1    +    0    = -127       C=    0
-128    +  127    +    0    =   -1       C=    0
-128    + -128    +    0    =    0       C=    1
-128    + -127    +    0    =    1       C=    1
-128    +   -1    +    0    =  127       C=    1
-127    +    0    +    0    = -127       C=    0
-127    +    1    +    0    = -126       C=    0
-127    +  127    +    0    =    0       C=    1
-127    + -128    +    0    =    1       C=    1
-127    + -127    +    0    =    2       C=    1
-127    +   -1    +    0    = -128       C=    1
  -1    +    0    +    0    =   -1       C=    0
  -1    +    1    +    0    =    0       C=    1
  -1    +  127    +    0    =  126       C=    1
  -1    + -128    +    0    =  127       C=    1
  -1    + -127    +    0    = -128       C=    1
  -1    +   -1    +    0    =   -2       C=    1
   0    +    0    +    1    =    1       C=    0
   0    +    1    +    1    =    2       C=    0
   0    +  127    +    1    = -128       C=    0
   0    + -128    +    1    = -127       C=    0
   0    + -127    +    1    = -126       C=    0
   0    +   -1    +    1    =    0       C=    1
   1    +    0    +    1    =    2       C=    0
   1    +    1    +    1    =    3       C=    0
   1    +  127    +    1    = -127       C=    0
   1    + -128    +    1    = -126       C=    0
   1    + -127    +    1    = -125       C=    0
   1    +   -1    +    1    =    1       C=    1
 127    +    0    +    1    = -128       C=    0
 127    +    1    +    1    = -127       C=    0
 127    +  127    +    1    =   -1       C=    0
 127    + -128    +    1    =    0       C=    1
 127    + -127    +    1    =    1       C=    1
 127    +   -1    +    1    =  127       C=    1
-128    +    0    +    1    = -127       C=    0
-128    +    1    +    1    = -126       C=    0
-128    +  127    +    1    =    0       C=    1
-128    + -128    +    1    =    1       C=    1
-128    + -127    +    1    =    2       C=    1
-128    +   -1    +    1    = -128       C=    1
-127    +    0    +    1    = -126       C=    0
-127    +    1    +    1    = -125       C=    0
-127    +  127    +    1    =    1       C=    1
-127    + -128    +    1    =    2       C=    1
-127    + -127    +    1    =    3       C=    1
-127    +   -1    +    1    = -127       C=    1
  -1    +    0    +    1    =    0       C=    1
  -1    +    1    +    1    =    1       C=    1
  -1    +  127    +    1    =  127       C=    1
  -1    + -128    +    1    = -128       C=    1
  -1    + -127    +    1    = -127       C=    1
  -1    +   -1    +    1    =   -1       C=    1
   0    -    0    =    0   C=    1
   0    -    1    =   -1   C=    1
   0    -  127    = -127   C=    1
   0    - -128    = -128   C=    1
   0    - -127    =  127   C=    1
   0    -   -1    =    1   C=    1
   1    -    0    =    1   C=    1
   1    -    1    =    0   C=    0
   1    -  127    = -126   C=    1
   1    - -128    = -127   C=    1
   1    - -127    = -128   C=    1
   1    -   -1    =    2   C=    1
 127    -    0    =  127   C=    1
 127    -    1    =  126   C=    0
 127    -  127    =    0   C=    0
 127    - -128    =   -1   C=    1
 127    - -127    =   -2   C=    1
 127    -   -1    = -128   C=    1
-128    -    0    = -128   C=    1
-128    -    1    =  127   C=    0
-128    -  127    =    1   C=    0
-128    - -128    =    0   C=    0
-128    - -127    =   -1   C=    1
-128    -   -1    = -127   C=    1
-127    -    0    = -127   C=    1
-127    -    1    = -128   C=    0
-127    -  127    =    2   C=    0
-127    - -128    =    1   C=    0
-127    - -127    =    0   C=    0
-127    -   -1    = -126   C=    1
  -1    -    0    =   -1   C=    1
  -1    -    1    =   -2   C=    0
  -1    -  127    = -128   C=    0
  -1    - -128    =  127   C=    0
  -1    - -127    =  126   C=    0
  -1    -   -1    =    0   C=    0
   0    -    0    -    0    =    0       C=    1
   0    -    1    -    0    =   -1       C=    1
   0    -  127    -    0    = -127       C=    1
   0    - -128    -    0    = -128       C=    1
   0    - -127    -    0    =  127       C=    1
   0    -   -1    -    0    =    1       C=    1
   1    -    0    -    0    =    1       C=    1
   1    -    1    -    0    =    0       C=    0
   1    -  127    -    0    = -126       C=    1
   1    - -128    -    0    = -127       C=    1
   1    - -127    -    0    = -128       C=    1
   1    -   -1    -    0    =    2       C=    1
 127    -    0    -    0    =  127       C=    1
 127    -    1    -    0    =  126       C=    0
 127    -  127    -    0    =    0       C=    0
 127    - -128    -    0    =   -1       C=    1
 127    - -127    -    0    =   -2       C=    1
 127    -   -1    -    0    = -128       C=    1
-128    -    0    -    0    = -128       C=    1
-128    -    1    -    0    =  127       C=    0
-128    -  127    -    0    =    1       C=    0
-128    - -128    -    0    =    0       C=    0
-128    - -127    -    0    =   -1       C=    1
-128    -   -1    -    0    = -127       C=    1
-127    -    0    -    0    = -127       C=    1
-127    -    1    -    0    = -128       C=    0
-127    -  127    -    0    =    2       C=    0
-127    - -128    -    0    =    1       C=    0
-127    - -127    -    0    =    0       C=    0
-127    -   -1    -    0    = -126       C=    1
  -1    -    0    -    0    =   -1       C=    1
  -1    -    1    -    0    =   -2       C=    0
  -1    -  127    -    0    = -128       C=    0
  -1    - -128    -    0    =  127       C=    0
  -1    - -127    -    0    =  126       C=    0
  -1    -   -1    -    0    =    0       C=    0
   0    -    0    -    1    =   -1       C=    1
   0    -    1    -    1    =   -2       C=    0
   0    -  127    -    1    = -128       C=    1
   0    - -128    -    1    =  127       C=    1
   0    - -127    -    1    =  126       C=    1
   0    -   -1    -    1    =    0       C=    1
   1    -    0    -    1    =    0       C=    1
   1    -    1    -    1    =   -1       C=    0
   1    -  127    -    1    = -127       C=    1
   1    - -128    -    1    = -128       C=    1
   1    - -127    -    1    =  127       C=    1
   1    -   -1    -    1    =    1       C=    1
 127    -    0    -    1    =  126       C=    1
 127    -    1    -    1    =  125       C=    0
 127    -  127    -    1    =   -1       C=    0
 127    - -128    -    1    =   -2       C=    0
 127    - -127    -    1    =   -3       C=    1
 127    -   -1    -    1    =  127       C=    1
-128    -    0    -    1    =  127       C=    1
-128    -    1    -    1    =  126       C=    0
-128    -  127    -    1    =    0       C=    0
-128    - -128    -    1    =   -1       C=    0
-128    - -127    -    1    =   -2       C=    0
-128    -   -1    -    1    = -128       C=    1
-127    -    1    -    1    =  127       C=    0
-127    -  127    -    1    =    1       C=    0
-127    - -128    -    1    =    0       C=    0
-127    - -127    -    1    =   -1       C=    0
-127    -   -1    -    1    = -127       C=    1
  -1    -    0    -    1    =   -2       C=    0
  -1    -    1    -    1    =   -3       C=    0
  -1    -  127    -    1    =  127       C=    0
  -1    - -128    -    1    =  126       C=    0
  -1    - -127    -    1    =  125       C=    0
  -1    -   -1    -    1    =   -1       C=    0
   0    +    1    =    1
   1    +    1    =    2
 127    +    1    = -128
-128    +    1    = -127
-127    +    1    = -126
  -1    +    1    =    0
   0    -    1    =   -1
   1    -    1    =    0
 127    -    1    =  126
-128    -    1    =  127
-127    -    1    = -128
  -1    -    1    =   -2

   0  AND    0    =    0
   0  AND    1    =    0
   0  AND  127    =    0
   0  AND -128    =    0
   0  AND -127    =    0
   0  AND   -1    =    0
   1  AND    0    =    0
   1  AND    1    =    1
   1  AND  127    =    1
   1  AND -128    =    0
   1  AND -127    =    1
   1  AND   -1    =    1
 127  AND    0    =    0
 127  AND    1    =    1
 127  AND  127    =  127
 127  AND -128    =    0
 127  AND -127    =    1
 127  AND   -1    =  127
-128  AND    0    =    0
-128  AND    1    =    0
-128  AND  127    =    0
-128  AND -128    = -128
-128  AND -127    = -128
-128  AND   -1    = -128
-127  AND    0    =    0
-127  AND    1    =    1
-127  AND  127    =    1
-127  AND -128    = -128
-127  AND -127    = -127
-127  AND   -1    = -127
  -1  AND    0    =    0
  -1  AND    1    =    1
  -1  AND  127    =  127
  -1  AND -128    = -128
  -1  AND -127    = -127
  -1  AND   -1    =   -1
   0   OR    0    =    0
   0   OR    1    =    1
   0   OR  127    =  127
   0   OR -128    = -128
   0   OR -127    = -127
   0   OR   -1    =   -1
   1   OR    0    =    1
   1   OR    1    =    1
   1   OR  127    =  127
   1   OR -128    = -127
   1   OR -127    = -127
   1   OR   -1    =   -1
 127   OR    0    =  127
 127   OR    1    =  127
 127   OR  127    =  127
 127   OR -128    =   -1
 127   OR -127    =   -1
 127   OR   -1    =   -1
-128   OR    0    = -128
-128   OR    1    = -127
-128   OR  127    =   -1
-128   OR -128    = -128
-128   OR -127    = -127
-128   OR   -1    =   -1
-127   OR    0    = -127
-127   OR    1    = -127
-127   OR  127    =   -1
-127   OR -128    = -127
-127   OR -127    = -127
-127   OR   -1    =   -1
  -1   OR    0    =   -1
  -1   OR    1    =   -1
  -1   OR  127    =   -1
  -1   OR -128    =   -1
  -1   OR -127    =   -1
  -1   OR   -1    =   -1
   0  XOR    0    =    0
   0  XOR    1    =    1
   0  XOR  127    =  127
   0  XOR -128    = -128
   0  XOR -127    = -127
   0  XOR   -1    =   -1
   1  XOR    0    =    1
   1  XOR    1    =    0
   1  XOR  127    =  126
   1  XOR -128    = -127
   1  XOR -127    = -128
   1  XOR   -1    =   -2
 127  XOR    0    =  127
 127  XOR    1    =  126
 127  XOR  127    =    0
 127  XOR -128    =   -1
 127  XOR -127    =   -2
 127  XOR   -1    = -128
-128  XOR    0    = -128
-128  XOR    1    = -127
-128  XOR  127    =   -1
-128  XOR -128    =    0
-128  XOR -127    =    1
-128  XOR   -1    =  127
-127  XOR    0    = -127
-127  XOR    1    = -128
-127  XOR  127    =   -2
-127  XOR -128    =    1
-127  XOR -127    =    0
-127  XOR   -1    =  126
  -1  XOR    0    =   -1
  -1  XOR    1    =   -2
  -1  XOR  127    = -128
  -1  XOR -128    =  127
  -1  XOR -127    =  126
  -1  XOR   -1    =    0
   0  INV   =    0
   1  INV   =   -1
 127  INV   = -127
-128  INV   = -128
-127  INV   =  127
  -1  INV   =    1
   0  CMP    0    =    0
   0  CMP    1    =   -1
   0  CMP  127    = -127
   0  CMP -128    = -128
   0  CMP -127    =  127
   1  CMP    0    =    1
   1  CMP    1    =    0
   1  CMP  127    = -126
   1  CMP -128    = -127
   1  CMP -127    = -128
   1  CMP   -1    =    2
 127  CMP    0    =  127
 127  CMP    1    =  126
 127  CMP  127    =    0
 127  CMP -128    =   -1
 127  CMP -127    =   -2
 127  CMP   -1    = -128
-128  CMP    0    = -128
-128  CMP    1    =  127
-128  CMP  127    =    1
-128  CMP -128    =    0
-128  CMP -127    =   -1
-128  CMP   -1    = -127
-127  CMP    0    = -127
-127  CMP    1    = -128
-127  CMP  127    =    2
-127  CMP -128    =    1
-127  CMP -127    =    0
-127  CMP   -1    = -126
  -1  CMP    0    =   -1
  -1  CMP    1    =   -2
  -1  CMP  127    = -128
  -1  CMP -128    =  127
  -1  CMP -127    =  126
  -1  CMP   -1    =    0
   0 CLRA    =    0
   1 CLRA    =    0
 127 CLRA    =    0
-128 CLRA    =    0
-127 CLRA    =    0
  -1 CLRA    =    0

 */
