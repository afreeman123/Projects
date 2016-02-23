using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNamespace
{
    //cannot create an instance of an abstract class
    abstract class MyClass
    {
        public string Name = "Mr. Smith";
        public int Age = 30;

        public static void Message(string message)
        {
            MessageBox.Show(message);
        }

        public abstract void ShowMessage(string message);
    }

    class MySecondClass : MyClass
    {
        public override void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }

    //cant have multiple structs

    /*interface IClient
    {
        public string Name;
    }*/
}
