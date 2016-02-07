using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroComputer
{
    public partial class MicroBaby : Form
    {



        public MicroBaby()
        {
            InitializeComponent();
        }


        private void runProgram_Click(object sender, EventArgs e)
        {

            while (!CPU.Globals._PROGRAM_ARRAY.Equals(null))
            {

                CPU.Globals._IR = (byte)CPU.Globals._PROGRAM_ARRAY[CPU.Globals._PC];


            }

            dispPC.Text = CPU.Globals._PC.ToString();


        }

        private void runStep_Click(object sender, EventArgs e)
        {

            if (CPU.Globals._OPCODE_ARRAY.Count == 0 || CPU.Globals._PC >= CPU.Globals._OPCODE_ARRAY.Count)
            {
                dispIR.Text = "Please load program first.";
            }
            else
            {
                dispIR.Text = CPU.Globals._OPCODE_ARRAY[CPU.Globals._PC];
                CPU.Globals._DATA_BUS = Convert.ToByte(CPU.Converters.StringToSbyte(CPU.Globals._OPCODE_ARRAY[CPU.Globals._PC + 1]));
                dispDataBus.Text = CPU.Globals._DATA_BUS.ToString();
                dispPC.Text = CPU.Globals._PC.ToString();
                dispAC.Text = CPU.Globals._AC.ToString();

            }


        }

        private void loadProgram_Click(object sender, EventArgs e)
        {
            opCodes.Clear();
            CPU.Globals._PROGRAM_TOKENS.Clear();
            CPU.Globals._OPCODE_ARRAY.Clear();
            CPU.Globals._INSTRUCTION_ARRAY.Clear();
            string[] tempArray = programEditor.Lines;
            tokenize(tempArray);
            convertToOpCode();

            if (CPU.Globals._INSTRUCTION_ARRAY.Count > 0)
            {

                string hold = CPU.Globals._OPCODE_ARRAY[0].ToString();
                opCodes.Text = hold;
                //output opcodes to opCodes textbox 
                string opcodestring = "";
                int i = 0;




                foreach (string s in CPU.Globals._OPCODE_ARRAY)
                {
                    opcodestring += i.ToString("X2") + "   " + s + System.Environment.NewLine;
                    i++;
                }



                opCodes.Text = opcodestring;
            }

            /*
            input load in text
            Add #$13;
            SUb $23;
            XOR #$A2;
            INV;
            Add #$13;
            Add $13;
            INc;
            jmp #$F1;
output:
01000010
00010011
01010001
00100011
01010110
10100010
01011000
01000010
00010011
01000001
00010011
*/


        }

        public static void tokenize(String[] program)
        {
            char[] delimiterChars = { ' ', ',', '.', ';', ':', '\t' };
            String hold = "";

            for (int counter = 0; counter < program.Length; counter++)
            {
                hold += program[counter];

            }

            String[] tempArray2 = hold.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);



            for (int i = 0; i < tempArray2.Length; i++)
            {
                String temp = tempArray2[i];

                CPU.Globals._PROGRAM_TOKENS.Add(temp.ToUpper());

            }




        }
        public static void convertToOpCode()
        {
            for (int i = 0; i < CPU.Globals._PROGRAM_TOKENS.Count; i++)
            {
                int j = Array.IndexOf(CPU.Globals._INSTR, CPU.Globals._PROGRAM_TOKENS[i]);
                CPU.Instr newInstr = new CPU.Instr_ADD();

                switch (j)
                {
                    case 0:
                        break;

                    case 1:
                        break;
                    case 2:
                        newInstr = new CPU.Instr_ADD();
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        newInstr = new CPU.Instr_INC();

                        break;

                    case 7:
                        break;

                    case 8:
                        break;

                    case 9:
                        break;
                    case 10:

                        break;
                    case 11:

                        break;
                    case 12:

                        break;
                    case 13:

                        break;
                    case 14:
                        newInstr = new CPU.Instr_JMP();

                        break;
                    default:
                        break;
                }
                if (j >= 0)
                {

                    if (!newInstr.isJMP && !newInstr.isInherent)
                    {
                        String addrMode = CPU.Globals._PROGRAM_TOKENS[i + 1];
                        if (addrMode.First() == '#')
                        {
                            newInstr.opcode += "10";
                            newInstr.isImmediate = false;
                            newInstr.dataopcode = byte.Parse(addrMode.Substring(2), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture);

                        }
                        else {
                            newInstr.opcode += "01";
                            newInstr.isImmediate = true;
                            newInstr.dataopcode = byte.Parse(addrMode.Substring(1), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        i++;
                    }
                    else if (newInstr.isJMP)
                    {
                        String addrMode = CPU.Globals._PROGRAM_TOKENS[i + 1];
                        newInstr.dataopcode = byte.Parse(addrMode.Substring(2), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture);
                        i++;
                    }

                }
                CPU.Globals._INSTRUCTION_ARRAY.Add(newInstr);

            }

            foreach (CPU.Instr s in CPU.Globals._INSTRUCTION_ARRAY)
            {
                CPU.Globals._OPCODE_ARRAY.Add(s.opcode);

                if (!s.isInherent)
                {
                    CPU.Globals._OPCODE_ARRAY.Add(Convert.ToString(s.dataopcode, 2).PadLeft(8, '0'));
                }
            }




            /*
            CPU.Globals._OPCODE_ARRAY = new List<String>();
            // go through program
            for (int i = 0; i < CPU.Globals._PROGRAM_TOKENS.Count; i++)
            {
                int j = Array.IndexOf(CPU.Globals._INSTR, CPU.Globals._PROGRAM_TOKENS[i]);
                if (j >= 0)
                {
                    String inst = CPU.Globals._OPCODE[j];
                    CPU.Globals._OPCODE_ARRAY.Add(inst);
                    
                    //inherent ignores 2nd byte
                    if (j != 6 && j != 7 && j!= 10) {
                //read direct or immediate
                String addrMode = CPU.Globals._PROGRAM_TOKENS[i + 1];
                if (addrMode.First() == '#')
                {
                    addrMode = addrMode.Substring(2);
                }
                else {
                    addrMode = addrMode.Substring(1);
                    String changeOpcode = CPU.Globals._OPCODE[j].Substring(0, 6) + "01";
                    CPU.Globals._OPCODE_ARRAY.RemoveAt(i);
                    CPU.Globals._OPCODE_ARRAY.Add(changeOpcode);
                }
                addrMode=Int32.Parse(Convert.ToString(byte.Parse(addrMode, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture),2)).ToString("00000000");
                CPU.Globals._OPCODE_ARRAY.Add(addrMode);
                        i++;
                    }
                }
                else
                {
                    //TODO
                    //give error message;
                }
            }
            */

        }


        private void updateMem_Click(object sender, EventArgs e)
        {
            sbyte memAdd = (sbyte)Int32.Parse(enterMemAdd.SelectedItem.ToString());
            sbyte memValue = (sbyte)Int32.Parse(enterMemContent.Text.ToString());

            System.Console.WriteLine("Mem Address: " + memAdd);
            System.Console.WriteLine("Mem Content: " + memValue);
            CPU.Globals._MEMORY[memAdd] = memValue;
        }



        private void dispPC_TextChanged(object sender, EventArgs e)
        {

        }

        private void dispIR_TextChanged(object sender, EventArgs e)
        {

        }

        private void dispAC_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sim_Click(object sender, EventArgs e)
        {

        }

        private void dispDataBus_TextChanged(object sender, EventArgs e)
        {

        }

        private void dispMemAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void dispMemContent_TextChanged(object sender, EventArgs e)
        {

        }

        private void programEditor_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterMemAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CPU.Globals._CARRY = !CPU.Globals._CARRY;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CPU.Globals._OVERFLOW = !CPU.Globals._OVERFLOW;
            Console.WriteLine(CPU.Globals._OVERFLOW);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CPU.Globals._ZERO = !CPU.Globals._ZERO;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CPU.Globals._NEGATIVE = !CPU.Globals._NEGATIVE;
        }


    }
}
