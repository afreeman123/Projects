using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class MyClass
    {
        //private 
        string Name;

        //constructor
        public MyClass(string name)
        {
            Name = name;
        }

        //when multiple constructors, have to call different types of parameters
        //i.e. can't have 2 constructors passing one string parameter
        public MyClass()
        {

        }
    }
}
