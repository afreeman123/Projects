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
            /*int a = 5;
            int b = 3;
            //MessageBox can only display string
            MessageBox.Show((a + b).ToString());*/

            string[] Names = new string[5];
            Names[0] = "Aidan";
            MessageBox.Show(Names[0]);

            int[] numbers = { 555, 666, 777 };
            MessageBox.Show(numbers[1].ToString());


        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("You are hovering your mouse over the button");
        }
    }
        
}
