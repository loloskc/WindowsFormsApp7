using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp7
{

    public partial class Form1 : Form
    {
        string textFile = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var readFile = new StreamReader("C:/logs.txt");
            textFile = readFile.ReadToEnd();
            label1.Text = textFile;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var writeFile = new StreamWriter("C:/logs2.txt");

            char[] wordLetter = textFile.ToCharArray();
            int flag = 0;
            for(int i = 0; i < wordLetter.Length; i++)
            {
                if (!char.IsLetterOrDigit(wordLetter[i]))
                {

                    Array.Reverse(wordLetter, flag, i - flag);
                    flag = i+1;
                }
            }
            label2.Text = (new string(wordLetter, 0, wordLetter.Length-1));

            /*var str = new StringBuilder();
            foreach(var word in textFile.Split(' '))
            {
                str.Append(word.Reverse().ToArray());
                str.Append(" ");
            }
            writeFile.WriteLine(str.ToString());*/
            
        }
    }
}
