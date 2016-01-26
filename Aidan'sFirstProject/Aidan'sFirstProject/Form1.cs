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
            //object can be any var type
            object myObj = true;
            MessageBox.Show(myObj.ToString());

            //changes text property of button1
            button1.Text = "Aidan";

            button1.Height = 60;

            textBox1.Text = "Aidan";
            textBox1.MaxLength = 2;

            //disables button
            button1.Enabled = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You are hovering your mouse over the button");
        }

    }
        
}
