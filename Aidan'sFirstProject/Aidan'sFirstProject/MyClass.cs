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
        //event has a subscriber method which is called when the event is raised
        //special type of delegate where you only use += and -= to add and take methods away
        public event EventHandler OnPropertyChanged;

        string name = "";

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(this, new EventArgs());
            }
        }
    }
}
