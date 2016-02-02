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
            string[] Names = new string[5];
            Names[0] = "Aidan";
            MessageBox.Show(Names[0]);

            int[] numbers = { 555, 666, 777 };
            MessageBox.Show(numbers[1].ToString());*/

            //A list is like an array but you do not have to specify the length
            List<string> Names = new List<string>();

            Names.Add("Aidan");
            Names.Add("Joe");
            MessageBox.Show(Names[0]);

            List<int> Numbers = new List<int>();

            Numbers.Add(5);
            Numbers.Add(667);
            MessageBox.Show(Numbers[1].ToString());

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You are hovering your mouse over the button");
        }
    }
        
}
