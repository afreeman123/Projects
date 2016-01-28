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
            /*if(textBox1.Text == "Aidan")
            {
                MessageBox.Show("Hello");
            }
            else if(textBox1.Text == "Bob")
            {
                MessageBox.Show("Yo");
            }
            else if(textBox1.Text == "Joe")
            {
                MessageBox.Show("Hi");
            }
            else
            {
                MessageBox.Show("Sorry your name isn't important");
            }*/

            string myString = null;

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
            }

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You are hovering your mouse over the button");
        }
    }
        
}
