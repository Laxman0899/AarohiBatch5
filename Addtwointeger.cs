using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractice
{
    internal class Addtwointeger
    {
        public void AddNumber()
        {
            int a, b, result;

            Console.WriteLine("Enter First Number :");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Number : ");
            b = int.Parse(Console.ReadLine());

            result = a + b;

            Console.WriteLine("Addition is {0}", result);
            

            int yearofexperience = 2;
            string name = "Trupti shinde";
            string Destination = "web Devloper";
            string company = "Aarohi";

            Console.WriteLine("My experience is {0},My destination is {2} and My name is {1},my ComPany NAme is {3}", yearofexperience, name, Destination, company);
            
        
        }
    }
}
