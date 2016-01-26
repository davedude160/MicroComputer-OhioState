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


        }
    }
}
