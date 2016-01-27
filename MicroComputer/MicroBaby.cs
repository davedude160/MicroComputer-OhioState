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

            char[] delimiterChars = { ' ', ',', '.', ';', ':', '\t' };
            string[] tempArray = programEditor.Lines;

            String hold=""; 

            for (int counter=0; counter < tempArray.Length; counter++)
            {
                hold +=tempArray[counter]; 

            }

            String[] tokens= hold.Split(delimiterChars, System.StringSplitOptions.RemoveEmptyEntries);
            CPU.Globals._PROGRAM_TOKENS = new string[tokens.Length]; 

             
            for (int i = 0; i < tokens.Length; i++)
            {
                 String temp =tokens[i];
                 CPU.Globals._PROGRAM_TOKENS[i] = temp.ToUpper();

            }
            
            
             
        }
         

        public static void convertToOpCode()
        {
            // go through program
            for (int i = 0; i < CPU.Globals._PROGRAM_ARRAY.Length; i++)
            {
                int j = Array.IndexOf(CPU.Globals._INSTR, CPU.Globals._PROGRAM_ARRAY[i]);
                if (j >= 0)
                {
                    CPU.Globals._OPCODE_ARRAY.SetValue(CPU.Globals._OPCODE[i], i);
                }
                else
                {
                    //TODO
                    //give error message;

                }

                //read direct or immediate
                String addrMode = CPU.Globals._INSTR[i + 1];
                Byte addrOrNum;
                if (addrMode.First() == '#')
                {
                    addrMode = addrMode.Substring(2);
                }
                else {
                    addrMode = addrMode.Substring(1);
                    String changeOpcode = CPU.Globals._OPCODE[i].Substring(0, 6) + "01";
                    CPU.Globals._OPCODE_ARRAY.SetValue(changeOpcode, i);
                }
                addrOrNum = Convert.ToByte(addrMode, 16);
                CPU.Globals._OPCODE_ARRAY.SetValue(addrOrNum.ToString(), ++i);

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
