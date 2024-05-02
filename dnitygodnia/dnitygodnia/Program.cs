
using dnitygodnia;
using dnitygodnia.core;

internal class Program
{
    private static void Main(string[] args)
    {
    

        var guesser = new DayGuesser();

        guesser.IntroduceTheApp();
        guesser.AskUserForTheirBirthDate();
        guesser.CalculateDayOfTheWeek();
        guesser.PrintBirthDate();
    }
}