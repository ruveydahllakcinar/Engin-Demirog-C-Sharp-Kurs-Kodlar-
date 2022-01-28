using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
                
            }
            Find();

            Console.ReadLine();
        }

        private static void Find()
        {
            List<string> student = new List<string> { "Hilal", "Tuğçe", "Kadir" };
            if (!student.Contains("Ahmet"))

            {
                throw new RecordNotFoundException("Record not found"); //Hata oluştur
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] student = new string[3] { "Engin", "Ruveyda", "Tuğçe" };
                student[3] = "Ahmet";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);

            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
