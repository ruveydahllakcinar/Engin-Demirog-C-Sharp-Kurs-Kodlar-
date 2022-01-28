using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //   ArrayList();
            //List();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Table", "tablo");
            dictionary.Add("Book", "Kitap");

            // Console.WriteLine(dictionary["Table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Denizli");
            Console.WriteLine(cities.Contains("Adana"));
            foreach (var city in cities)
            {
                Console.WriteLine(city);

            }
            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Ruveyda" });
            //customers.Add(new Customer { Id = 2, FirstName = "Tuğçe" });

            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, FirstName = "Ruveyda" },
                new Customer { Id = 2, FirstName = "Tuğçe" }
            };


            var customer1 = new Customer
            {
                Id = 3,
                FirstName = "Kadir"
            };
            customers.Add(customer1);
            customers.AddRange(new Customer[2]
            {
                new Customer { Id = 4, FirstName = "İnci" },
                new Customer { Id = 5, FirstName = "Saliha" }
            });

            //customers.Clear();
            var index = customers.IndexOf(customer1);
            Console.WriteLine("Index : {0}", index);

            var index2 = customers.LastIndexOf(customer1);
            Console.WriteLine("Index : {0}", index2);
            customers.Remove(customer1);

            foreach (var customer in customers)
            {

                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.FirstName);
            }
            var count = customers.Count;
            Console.WriteLine("Count:{0}", count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add("İstanbul");
            cities.Add(1);
            cities.Add('A');
            foreach (var city in cities)
            {
                Console.WriteLine(city);

            }
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
