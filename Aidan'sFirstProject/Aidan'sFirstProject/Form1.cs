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
            /*int i = 17;

            switch(textBox1.Text)
            {
                case "Aidan":
                    MessageBox.Show("Hello");
                    break;
                case "Bob":
                    MessageBox.Show("Yo");
                    break;
                default:
                    MessageBox.Show("Your name is not important");
                    break;
            }

            switch(i)
            {
                case 4:
                    MessageBox.Show("You are too young");
                    break;
                case 17:
                    MessageBox.Show("You can drive");
                    break;
                default:
                    MessageBox.Show("Your age isn't relevant");
                    break;
            }*/

            int a = 5;
            int b = 3;
            //MessageBox can only display string
            MessageBox.Show((a + b).ToString());


        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You are hovering your mouse over the button");
        }
    }
        
}
