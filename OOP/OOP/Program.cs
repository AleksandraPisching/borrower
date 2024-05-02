
namespace OOP
{
    internal class Program
    {
        public static IManager GetManager()
        {
            return new FileManager();
        }
        private static void Main(string[] args)
        {

            var calulator = new calculator();

            var suma = calulator.Add(5, 25);

            Console.WriteLine(suma);


        }
    }

}


