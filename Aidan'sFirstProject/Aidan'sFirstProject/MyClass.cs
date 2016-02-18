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
        //available to all using the namespace
        public string name = "Bob";

        //available only to the namespace
        protected int Age = 10;

        //available only to the class where it is defined
        private string thing = "Hello";

        public void ShowMessage(string Message)
        {
            MessageBox.Show(Message);
        }
    }

    //Inheriting a class
    class MySecondClass : MyClass
    {
        public string HairColour = "Brown";

        //overrides the method inherited in MyClass
        public new void ShowMessage(string Message)
        {
            //base class is MyClass, MySecondClass is derived
            MessageBox.Show(Message, "My Title");
        }
    }
}
