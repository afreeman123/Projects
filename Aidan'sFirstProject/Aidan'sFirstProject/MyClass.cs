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
        public string this[int index]
        {
            get
            {
                return MyArray[index];
            }
            set { MyArray[index] = value; }
        }
        string[] MyArray = { "Aidan", "Bob", "Joe" };

    }
}
