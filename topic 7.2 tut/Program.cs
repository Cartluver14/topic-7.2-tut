using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic_7._2_tut
{
    internal class Program
    {
        static void Main(string[] args)

        {

            //int number1;
            //int number2;
            //int number3;
            //Console.WriteLine("What 3 numbers would you like me to count to?");
            //number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("second number");
            //number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("third number");
            //number3 = int.Parse(Console.ReadLine());



            //Part 1 
            //for (int i = number1; i <= number2; i = i + number3)
            //{
            //Console.WriteLine(i + ": " );

            //}
            //Console.ReadLine();

            //Console.WriteLine("countdown");


            //for (int i = 10; i >= 0; --i)
            //{
            // Console.WriteLine(i);
            //}
            //Console.ReadLine();

            //Console.WriteLine("countdown");


            //Part 2
            //for (int i = -10; i < 12; i+=2)
            // {
            //   Console.WriteLine(i);Console.WriteLine(i*i);
            // }
            //   Console.ReadLine();

            string name;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            if (name == "aldworth")
            {
                for (int i = 1; i <= 5; i = i + 1)
                {

                    Console.WriteLine(i + ". " + name);
                }
                Console.ReadLine();


           

            }
            else
            {
                for (int i = 1; i <= 10; i = i + 1)
                {

                    Console.WriteLine(i + ". " + name);
                }
                Console.ReadLine();


            }


















        }


    }
}
