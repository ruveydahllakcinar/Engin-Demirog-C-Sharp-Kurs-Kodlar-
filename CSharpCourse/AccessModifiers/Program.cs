using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
        protected int id { get; set; }



        public void Save()
        {

        }

        public void Delete()
        {

        }
    }
    class Student:Customer
    {
        public void Save1()
        {
            

        }
    }
    public class Course  //Bağlı bulduğu proje içerisinde referans ihtiyacı olmadan kullanabilirsiniz.
    {
        public string Name { get; set; }
    }
}
