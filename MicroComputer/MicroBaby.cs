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

            String hold = "";

            for (int counter = 0; counter < tempArray.Length; counter++)
            {
                hold += tempArray[counter];

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
         
        public static void tokenize(object programEditor)
        {
            
        }
        public static void convertToOpCode()
        {
            
           
        }

        private void updateMem_Click(object sender, EventArgs e)
        {

        }

        private void memScroll_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
