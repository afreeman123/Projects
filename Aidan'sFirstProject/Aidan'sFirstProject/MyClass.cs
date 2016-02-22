using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNamespace
{
    //a part of the class
    partial class MyClass
    {
        public string Name = "Mr. Smith";
        public int Age = 30;

        partial void Message(string message);
    }

    //cant have multiple structs

    /*interface IClient
    {
        public string Name;
    }*/
}
