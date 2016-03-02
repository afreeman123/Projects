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
            OpenFileDialog ofd = new OpenFileDialog();

            //Filter what can be selected from explorer
            ofd.Filter = "PNG Image|*.png|DOC|*.docx";

            //Opens windows explorer from which you can select files
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                //shows file path as well as file name
                MessageBox.Show(ofd.FileName);
            }

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Shows only the file name
                MessageBox.Show(ofd.SafeFileName);
            }
        }
        

        private void button2_MouseHover(object sender, EventArgs e)
        {
            //Message("My name is Aidan", "From Aidan");
        }
    }
        
}