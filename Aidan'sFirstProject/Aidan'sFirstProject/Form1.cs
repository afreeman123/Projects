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
            for(int i=0; i<10; i++)
            {
                if (i == 0) continue; // skips rest of code in for loop when i==0

                if (i==2) break; //breaks out of for loop when i==2

                textBox1.Text += i.ToString();
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            //Message("My name is Aidan", "From Aidan");
        }
    }
        
}
Class1.cs