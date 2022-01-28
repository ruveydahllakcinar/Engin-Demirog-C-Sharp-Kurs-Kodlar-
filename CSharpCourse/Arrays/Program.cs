using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Ruveyda";
            students[2] = "Batuhan";
            string[] students2 = new[] { "Engin", "Ruveyda", "Batuhan" };

            foreach (var student in students)
            {
                Console.WriteLine(student);

            }
            Console.WriteLine("**************************");

            string[,] regions = new string[5, 3]
            {
            {"İstanbul","İzmit","Balıkesir" },
            { "Ankara","Konya","Kırklareli" },
            { "Antalya","Adana","Mersin" },
            { "Rize","Düzce","Trabzon" },
            { "İzmir","Muğla","Manisa" }

        };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("***********************");
            }
           
            Console.ReadLine();
        }
    }
}
