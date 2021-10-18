using System;

namespace Demo_inheritence_file_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementing different types of inheritance!!");

            ChildClass Obj1 = new ChildClass();
            Obj1.Display();
            Obj1.Child_Display();

            Car Dealer1 = new Car();
            Dealer1.TopSpeed();

            Maruthi Swift = new Maruthi();
            Swift.Engine_Type = "Manual";
            Swift.Name = "Swift Desire Tour";
            Swift.Warranty = 5;
            Console.WriteLine("Features of swift:\n{0}\n{1}\n{2}", Swift.Engine_Type, Swift.Name, Swift.Warranty);

            Hyundai HondaCity = new Hyundai();
            HondaCity.TopSpeed();
            HondaCity.Engine_Type = "Automatic";
            HondaCity.Warranty = 7;
            Console.WriteLine("Features of Hondacity:\n Engine Type:{0} Warranty:\n{1}", HondaCity.Engine_Type, HondaCity.Warranty);


        }
    }
}
