using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNamespace
{
    class MyClass
    {
        //delegate
        delegate void MyDelegate(string myString);

        public void ShowThoseMessages()
        {
            MyDelegate md = new MyDelegate(ShowMessage);
            md += ShowAnotherMessage;

            md("Aidan");
        }

        void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        void ShowAnotherMessage(string a)
        {
            MessageBox.Show(a, "Test");
        }
    }
}
