using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;,


namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {


            private static bool IsPrimeNumber(int number)
            {
                bool result = true;
                for (int i = 2; i < number - 1; i++)
                {
                    if (number % i == 0)
                    {
                        result = false;
                        i = number;
                    }
                }
            } return result;
            //for (int i = 2; i <= 100; i += 2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Finished!!!");
            //Console.WriteLine("**************");
            //int number1 = 10;
            //do
            //{
            //    Console.WriteLine(number1);
            //    number1--;

            //} while (number1 >= 11);


            //Console.WriteLine("**************");

            //int number2 = 100;
            //while (number2 >= 0)
            //{
            //    Console.WriteLine(number2);
            //    number2--;
            //}
            //Console.WriteLine("Now number is {0}", number2);
            //Console.WriteLine("**************");


            //string[] students = new[] { "Engin", "Ruveyda", "Batuhan" };

            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}

        }
    }
}



