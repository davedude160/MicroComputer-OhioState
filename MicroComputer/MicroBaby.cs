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

        }

        private void runStep_Click(object sender, EventArgs e)
        {

        }

        private void loadProgram_Click(object sender, EventArgs e)
        {
            
            string[] tempArray = programEditor.Lines;
            tokenize(tempArray);
            convertToOpCode();

            //output opcodes to opCodes textbox 
            string opcodestring="";

            foreach( string s in CPU.Globals._OPCODE_ARRAY){
                opcodestring += s + System.Environment.NewLine;
                
            }
            
            opCodes.Text = opcodestring;
            /*
            input load in text
            Add #$13;
            SUb $23;
            XOR #$A2;
            INV;
            Add #$13;
            Add $13;
            jmp #$23;
            jNC #$02;    

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

        public static void tokenize(String [] program)
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

            foreach (String s in CPU.Globals._PROGRAM_TOKENS)
            {

                System.Console.WriteLine(s);

            }


        }
        public static void convertToOpCode()
        {

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
                    if (j != 6 && j != 7 && j!= 10 & j != 12 &j != 13 &j !=14) {

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
            }
 

        private void updateMem_Click(object sender, EventArgs e)
        {

        }

        private void memScroll_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
