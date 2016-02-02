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
            //A list is like an array but you do not have to specify the length
            List<string> Names = new List<string>();

            Names.Add("Aidan");
            Names.Add("Joe");
            MessageBox.Show(Names[0]);

            List<int> Numbers = new List<int>();

            Numbers.Add(5);
            Numbers.Add(667);
            MessageBox.Show(Numbers[1].ToString());*/

            for (int i=0;i<5;i++)
            {
                MessageBox.Show("hello " + i.ToString());
            }

            List < int > numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(15);

            foreach (int s in numbers)
            {
                MessageBox.Show(s.ToString());
            }

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You are hovering your mouse over the button");
        }
    }
        
}
