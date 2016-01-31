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
            while (!CPU.Globals._PROGRAM_ARRAY.Equals(null)) {

                CPU.Globals._IR = (byte) CPU.Globals._PROGRAM_ARRAY[CPU.Globals._PC]; 

            switch (CPU.Globals._IR)
            {
                case  :
                     
                    break;
                case :
                     
                    break;
                default:
                   
                    break;
            }
            }

        }

        private void runStep_Click(object sender, EventArgs e)
        {

        }

        private void loadProgram_Click(object sender, EventArgs e)
        {
            
            string[] tempArray = programEditor.Lines;
            tokenize(tempArray);
            convertToOpCode();

            string hold = CPU.Globals._OPCODE_ARRAY[0].ToString(); 
            opCodes.Text=hold; 
            //output opcodes to opCodes textbox 


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
