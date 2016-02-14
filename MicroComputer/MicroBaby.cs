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
 

            if (CPU.Globals._INSTRUCTION_ARRAY.Count == 0 || CPU.Globals._INSTR_PC >= CPU.Globals._INSTRUCTION_ARRAY.Count)
            {
                if (!CPU.Globals.runflag)
                    dispIR.Text = "Please load program first.";
                else
                    dispIR.Text = "End of execution";
                //dispIR.Text = "Load Program."; 
                MessageBox.Show( "Please load program first.");
            }
            else {
                CPU.Globals.runflag = true;
                dispIR.Text = CPU.Globals._OPCODE_ARRAY[CPU.Globals._PC];
                dispPC.Text = CPU.Globals._PC.ToString();
                CPU.Instr currentInstr = CPU.Globals._INSTRUCTION_ARRAY[CPU.Globals._INSTR_PC];
                CPU.Globals._DATA_BUS = (byte)currentInstr.dataopcode;
                dispDataBus.Text = CPU.Globals._DATA_BUS.ToString();

                if (currentInstr.call == "STA")
                {
                    currentInstr.operation(CPU.Globals._AC, (sbyte)currentInstr.dataopcode);
                }else if (currentInstr.isJMP)
                {

                }
                else
                {
                    CPU.Globals._AC = currentInstr.operation(CPU.Globals._AC, (sbyte)currentInstr.dataopcode);
                }

                if (CPU.Globals._AC == 0)
                {
                    CPU.Globals._ZERO = true;
                    zeroFlag.Checked = true;
                }
                else
                {
                    CPU.Globals._ZERO = false;
                    zeroFlag.Checked = false;
                }

                if (CPU.Globals._AC < 0)
                {
                    CPU.Globals._NEGATIVE = true;
                    negFlag.Checked = true;
                }
                else
                {
                    CPU.Globals._NEGATIVE = false;
                    negFlag.Checked = false;
                }

<<<<<<< HEAD

                if (CPU.Globals._CARRY == true)
                {
                    carryFlag.Checked = true;
                }
                else
=======
                if(CPU.Globals._CARRY == true)
>>>>>>> origin/GUI-Update
                {
                    carryFlag.Checked = false;

                }
                else
                {
                    carryFlag.Checked = false;
                }

                dispPC.Text = CPU.Globals._PC.ToString();

                CPU.Globals._INSTR_PC++;
                dispAC.Text = CPU.Globals._AC.ToString();

            }


        }

        private void resetProgram_Click(object sender, EventArgs e)
        {
            CPU.Globals._PC = 0;
            dispPC.Text = CPU.Globals._PC.ToString();
            CPU.Globals._AC = 0;
            dispAC.Text = CPU.Globals._AC.ToString();
            CPU.Globals._IR = 0;
            dispIR.Text = CPU.Globals._IR.ToString();
            CPU.Globals._CARRY = false;
            carryFlag.Checked = false;
            CPU.Globals._OVERFLOW = false;
            CPU.Globals._NEGATIVE = false;
            negFlag.Checked = false;
            CPU.Globals._ZERO = false;
            zeroFlag.Checked = false;
            CPU.Globals._DATA_BUS = 0;
            CPU.Globals._INSTR_PC = 0;

            dispAC.Text = "";
            dispPC.Text = "";
            dispIR.Text = "";


        }


    private void refreshMem_Click(object sender, EventArgs e)
        {
            dispDataBus.Text = CPU.Globals._DATA_BUS.ToString();
            dispPC.Text = CPU.Globals._PC.ToString();
            dispAC.Text = CPU.Globals._AC.ToString();
            dispIR.Text = CPU.Globals._IR.ToString();
            loadProgram_Click(sender, e); 

            if (CPU.Globals._MEMORY.Length > 0)
            {

                //output opcodes to opCodes textbox 
                string dataString = "";

                int i = 0;

                foreach (sbyte s in CPU.Globals._MEMORY)
                {
                    String binary = Convert.ToString((sbyte)s, 2).PadLeft(8, '0');
                    if (binary.Length > 8)
                    {
                        binary = binary.Remove(0, 8);
                    }
                    const string format = "{0,-10} {1,-15} {2,-18}";
                    // Construct the strings.
                    string fmtOutputLine = string.Format(format, i.ToString("X2"), binary, s.ToString());
                    dataString += fmtOutputLine + System.Environment.NewLine;
                    i++;
                }

                dataMem.Text = dataString;
                dataMem2.Text = dataString;

            }
        }
        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader readFile = new System.IO.StreamReader(openFileDialog1.FileName);
                programEditor.Text = readFile.ReadToEnd();
                readFile.Close();
            }
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter writeFile = new System.IO.StreamWriter(saveFileDialog1.FileName);
                writeFile.Write(programEditor.Text);
                writeFile.Close();
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
            CPU.Globals._PC = 0;
            CPU.Globals._INSTR_PC = 0;
            if (CPU.Globals._INSTRUCTION_ARRAY.Count > 0)
            {

                string hold = CPU.Globals._OPCODE_ARRAY[0].ToString();
                opCodes.Text = hold;
                //output opcodes to opCodes textbox 
                string opcodestring = "";
                int i = 0;


                foreach (CPU.Instr ins in CPU.Globals._INSTRUCTION_ARRAY)
                {
                    opcodestring += i.ToString("X2") + "         " + CPU.Globals._OPCODE_ARRAY[i] + "         " + ins.call + System.Environment.NewLine;
                    i++;
                    if (!ins.isInherent)
                    {
                        opcodestring += i.ToString("X2") + "         " + CPU.Globals._OPCODE_ARRAY[i] + "         " + ins.data + System.Environment.NewLine;
                        i++;

                    }
                }



                opCodes.Text = opcodestring;
                programMem.Text = opcodestring;

            }

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
                Console.WriteLine(j);

                switch (j)
                {
                    case 0:
                        newInstr = new CPU.Instr_LDA();
                        break;
                        
                    case 1:
                        newInstr = new CPU.Instr_STA();
                        break;

                    case 2:
                        newInstr = new CPU.Instr_ADD();
                        break;

                    case 3:
                        newInstr = new CPU.Instr_ADDC();
                        break;

                    case 4:
                        newInstr = new CPU.Instr_SUB();
                        break;

                    case 5:
                        newInstr = new CPU.Instr_SUBC();
                        break;

                    case 6:
                        newInstr = new CPU.Instr_INC();
                        break;

                    case 7:
                        newInstr = new CPU.Instr_DEC();
                        break;

                    case 8:
                        newInstr = new CPU.Instr_AND();
                        break;

                    case 9:
                        newInstr = new CPU.Instr_OR();
                        break;
                    case 10:
                        newInstr = new CPU.Instr_INV();
                        break;
                    case 11:
                        newInstr = new CPU.Instr_XOR();
                        break;
                    case 12:
                        newInstr = new CPU.Instr_CLRA();
                        break;
                    case 13:
                        newInstr = new CPU.Instr_CMP();
                        break;

                    case 14:
                        newInstr = new CPU.Instr_JMP();
                        break;

                    default:
                        newInstr = new CPU.Instr_ADD();
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
                            newInstr.data = addrMode;
                            newInstr.dataopcode = byte.Parse(addrMode.Substring(2), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture);

                        }
                        else {
                            newInstr.opcode += "01";
                            newInstr.isImmediate = true;
                            newInstr.data = addrMode;

                            newInstr.dataopcode = byte.Parse(addrMode.Substring(1), System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture);
                        }
                        i++;
                    }
                    else if (newInstr.isJMP)
                    {
                        String addrMode = CPU.Globals._PROGRAM_TOKENS[i + 1];
                        newInstr.data = addrMode;

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

        }


        private void updateMem_Click(object sender, EventArgs e)
        {


            try
            {
                int memAdd = int.Parse(enterMemAdd.SelectedItem.ToString(), System.Globalization.NumberStyles.HexNumber);
                sbyte memValue = 0;

                try
                {
                    memValue = (sbyte)Int32.Parse(enterMemContent.Text.ToString());
                }
                catch (FormatException)
                {

                }
                System.Console.WriteLine("Mem Address: " + memAdd);
                System.Console.WriteLine("Mem Content: " + memValue);


                CPU.Globals._MEMORY[memAdd] = memValue;
                refreshMem_Click(sender, e);
            }

            catch (NullReferenceException)
            {

            }

        }
    }
}
