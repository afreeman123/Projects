using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //System is namespace, Windows is a subnamespace, Forms is a subnamespace of Windows
using MyNamespace;

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
            /*string myString = "";
            if(checkBox1.Checked)
            {
                myString = "It's checked";

            }else
            {
                myString = "It's not checked";
            }*/

            //Ternary Operator
            MessageBox.Show(checkBox1.Checked ? "It's checked" : "It's not checked");
        }

        private void Mc_OnPropertyChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The Property has changed");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            //Message("My name is Aidan", "From Aidan");
        }
    }
        
}