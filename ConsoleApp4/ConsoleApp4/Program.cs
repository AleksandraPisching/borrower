using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var liczba1 = int.Parse(Console.ReadLine());
            var liczba2 = int.Parse(Console.ReadLine());

            if (liczba1 > liczba2)
            {
                Console.WriteLine("liczba1 jest większa");
            }
            if (liczba1 < liczba2)

            {
                Console.WriteLine("liczba1 jest mniejsza");
            }
            if (liczba1 == liczba2)
            {
                Console.WriteLine("liczba1 jest równa liczie2");
            }
        }
    }
}
    

