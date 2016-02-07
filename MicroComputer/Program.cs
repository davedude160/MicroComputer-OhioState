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
            public static sbyte[] _MEMORY = new sbyte[255];
            public static string[] _INSTR =
                { "LDA","STA", "ADD", "ADDC", "SUB", "SUBC", "INC", "DEC", "AND", "OR", "INV", "XOR", "CLRA", "CMP", "JMP","JC","JNC","JS","JNS","JZ","JNZ","JCS","JNCS","JCNS","JNCNS","JCZ","JNCZ","JCNZ","JNCNZ","JSZ","JNSZ","JSNZ","JNSNZ" };
            public static string[] _OPCODE =
                { "10000010","10100010", "01000010", "01001010", "01000010", "01011010", "01001100", "01000100", "01011010", "01011110", "01011000", "01010110", "01001111","01000000","01001000", "01001010", "11000000","11100100","11100000","11010010","11010000","11001001","11001000","11110110","11110010","11110100","11110000","11101101","11101001","11101100","11101000","11011011","11011001","11011010","11011000" };

            public static List<String> _PROGRAM_TOKENS = new List<String>();
            public static List<String> _OPCODE_ARRAY= new List<String>();
            public static List<Instr> _INSTRUCTION_ARRAY = new List<Instr>();
            
            public static byte[] _PROGRAM_ARRAY = new byte[255];

            

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
            
           public Instr_ADD (){
                call = "ADD";
                opcode = "010000";
                isJMP = false;
                isInherent = false;
            }
            public override sbyte operation(sbyte a, sbyte b)
            {
                return a;
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




        public static class Instructions
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
                Globals._MEMORY[db] = Convert.ToSByte(ac);
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

            public static int SUB_DIRECT(sbyte ac, sbyte db)
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
                Globals._PC = (byte) Globals._MEMORY[db];

            }

        }

        public static class Converters
        {
            public static string SbyteToString(sbyte toBeConverted)
            {
                return (Convert.ToString(toBeConverted, 2).PadLeft(8, '0'));
            }

            public static sbyte StringToSbyte(string toBeConverted)
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
