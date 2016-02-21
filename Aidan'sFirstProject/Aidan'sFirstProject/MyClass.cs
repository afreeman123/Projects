using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNamespace
{
    struct Client : IClient
    {
        public Client(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name;
        public int Age;

        public void ClearClientInfo()
        {
            Name = "";
            Age = 0;
        }
    }

    //cant have multiple structs

    /*interface IClient
    {
        public string Name;
    }*/
}
