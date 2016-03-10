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
            //limited from 0 to 256
            byte myByte = 255;
            //sbyte can be negative int32
            sbyte mySbyte = -1;

            short myShort = -2144;
            Int16 int16 = myShort;

            int myInt = 0;
            Int32 int32 = myInt;

            long myLong = 0;
            Int64 int64 = myLong;

            //no limit to how big or small but only limited to 7 digits
            float myFloat = 12375476435;

            MessageBox.Show(myFloat.ToString());

            double d = 0.5;

            char myChar = 'd';
        }
        

        private void button2_MouseHover(object sender, EventArgs e)
        {
            //Message("My name is Aidan", "From Aidan");
        }
    }
        
}