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
            if(textBox1.Text == "Aidan")
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
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You are hovering your mouse over the button");
        }

    }
        
}
