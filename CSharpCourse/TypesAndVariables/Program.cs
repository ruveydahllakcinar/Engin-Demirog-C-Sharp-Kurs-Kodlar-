using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");

            int number1 = 2147483647;
            long number2 = 214748368;
            short number3 = 32767;
            byte number4 = 255;
            bool condition = false;
            char character = 'A';
            double number5 = 10.05;
            decimal number6 = 10.85m;
            var number7 = 10;
           // number7 = 'A';

            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine("Character id : {0}", (int)character);
            Console.WriteLine(Days.Friday);

            



            Console.ReadLine();
        }
        enum Days
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday //Birden fazla aynı şeyi kullanacağım zaman tek tek değiştirmek yerine Enum da atama yapıp yeri gelince kullanabilirim
        }
    }
}
