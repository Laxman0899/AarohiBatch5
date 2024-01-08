using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMenu();
            ExecutedMenuOption();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ReadLine();
        }

        public static void ExecutedMenuOption()
        {
            Console.Write("Enter Your Choice :");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Addtwointeger adding = new Addtwointeger();
                    adding.AddNumber();
                break;

                case 2:
                ControlStatement control = new ControlStatement();

                break;
            }
            Console.ReadLine();
        }

        public static void PrintMenu()
        {
            Console.WriteLine("____________Menu__________");
            Console.WriteLine("1.Add Two Integer");
        }

    }
}
