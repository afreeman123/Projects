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

        //constructor
        public MyClass(string name)
        {
            Name = name;
        }

        //property Name
        public string Name
        {
            get; //get the current state of property Name
            set; //set it to the new state
            
            //if set is set to private then it cannot be accessed ouside of the class file
        }

       
    }
}
