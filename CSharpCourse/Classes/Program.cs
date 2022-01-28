using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Denizli";
            customer.Id = 1;
            customer.FirstName = "Ruveyda";
            customer.LastName = "Akçınar";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "Eskişehir",
                FirstName = "Batuhan",
                LastName = "Başay"
            };

            Console.WriteLine(customer2.FirstName);

        }
    }


}
