using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aidan_sFirstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string myString = null;

            if(!checkBox1.Checked)
            {
                myString += "The checkbox is not checked";
            }

            bool myBool = true;
            if(myBool)
            {
                myString += "MyBool is true";
            }

            int i = 3;
            int b = 6;
            int c = 0;

            if(i>c)
            {
                myString += "i is greater than c";
            }

            if(!String.IsNullOrEmpty(myString))
            {
                MessageBox.Show(myString);
            }*/

            int i = 0;
            if (textBox1.Text == "Aidan" || checkBox1.Checked)
            {                            
                    MessageBox.Show("Hello");   
            }

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You are hovering your mouse over the button");
        }
    }
        
}
