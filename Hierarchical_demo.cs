using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_inheritence_file_handling
{
    class Hierarchical_demo
    {
    }
    class Car
    {
        public string Engine_Type { get; set; }

        public void TopSpeed()
        {
            Console.WriteLine("Top speed of cars");
        }
    }
    class Maruthi : Car
    {
        public void Car_Message()
        {
            Console.WriteLine("Maruthi:Drive happiness");
        }
    }
    class Hyundai : Car
    {
        public void Car_Display()
        {
            Console.WriteLine("car colour is gray");
        }
    }
    class Honda : Car
    {
        public void Display()
        {
            Console.WriteLine("Honda:drive luxary");
        }
    }
    class KIA : Hyundai
    {
        public void Display()
        {
            Console.WriteLine("KIA:This is motors company");
        }
    }
}
