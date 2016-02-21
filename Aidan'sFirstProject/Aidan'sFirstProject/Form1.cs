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
            Client client1 = new Client("Aidan", 21);
            client1.Name = "Aidan";
            client1.Age = 21;
            client1.ClearClientInfo();

            Client client2 = new Client();
            client2.Name = "Adam";
            client2.Age = 15;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            //Message("My name is Aidan", "From Aidan");
        }
    }
        
}