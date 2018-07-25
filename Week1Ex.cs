using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
             {
            Console.WriteLine("Hello World");
            Console.ReadLine();

            Q2();
            Q3();
            Q4();
            Q5();
        }

        public static void Q2()
        {
            int num1 = 74;
            int num2 = 36;
            int num3 = num1 + num2;
            Console.WriteLine(num3);
        
        }

        public static void Q3()
        { 
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = num1 * num2;
            Console.WriteLine(num1 + "x" + num2 + "=" + num3);
    
        }
                   

        public static void Q4()
        {
            Console.WriteLine ("Please First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please Last Name");
            string lastName  = Console.ReadLine();
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Hello " + fullName);
            Console.ReadLine();
        }
        public static void Q5()
        {

        }


    }

    class Q6
    {
        public static void q6()
        {

        }
    }
}
