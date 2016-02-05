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
             //call method message
             Message("Hello World!", "From Aidan");*/

            MessageBox.Show(MyMethod("Aidan"));
            MessageBox.Show(MyInt().ToString());
            MessageBox.Show(MyBool().ToString());
        }

        //New method
        void Message(string message, string title)
        {
            MessageBox.Show(message, title);
        }

        //returns a string
        string MyMethod(string name)
        {
            return name;
        }

        int MyInt()
        {
            return 6;
        }

        bool MyBool()
        {
            return true;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            //MessageBox.Show("You are hovering your mouse over the button");

            Message("My name is Aidan", "From Aidan");
        }
    }
        
}
