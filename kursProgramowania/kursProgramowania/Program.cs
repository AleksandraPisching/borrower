
internal class Program
{
    private static void Main(string[] args)
    {


        var liczba = 5;

        Console.WriteLine(PodwojLiczbe(liczba));
        Console.WriteLine(PodwojLiczbe1(out liczba));

        

    }
    private static int PrzekonwertujDoubleNaInta(double liczba)
    {

        if (int.TryParse(liczba.ToString(), out int liczba2))
        {
            return liczba2;
        }
        else
        {
            return 0; 
        }
         
    }

    private static void NazwaFunkcji()
    {
        Console.WriteLine(5);
    }

    private static int PodwojLiczbe(int liczba1)
    {
        return liczba1 * 2;
    }
    private static int PodwojLiczbe1(out int liczba1)
    {
        liczba1 = 2; 
        return liczba1 * 2;
    }
}