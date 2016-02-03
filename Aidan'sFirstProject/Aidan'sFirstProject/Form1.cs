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
            /*
            int i = 0;

            //pre-check while loop
            while (i < 10)
            {
                textBox1.Text += i.ToString();
                i++;
            }

            //post-check while loop
            do
            {
                textBox1.Text += i.ToString();
                i++;
            } while (i < 15);
            */

            try //execute this code
            {
                string[] names = new string[2];//"", ""
                string s = names[1];
            }
            catch(Exception ex) //if error
            {
                MessageBox.Show(ex.Message);
            }
            finally //execute this code after error checking regardless of failure or not
            {
                MessageBox.Show("Your code is done");
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You are hovering your mouse over the button");
        }
    }
        
}
