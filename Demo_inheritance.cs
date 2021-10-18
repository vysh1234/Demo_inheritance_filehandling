using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_inheritence_file_handling
{
    class Demo_inheritance
    {
        public void Display()
        {
            Console.WriteLine("this is my base class");
        }

    }
    class ChildClass : Demo_inheritance
    {
        public void Child_Display()
        {
            base.Display();
            Console.WriteLine("child class() display was invoked!!");
        }
    }
}
