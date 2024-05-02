
using dluznik;

internal class Program
{
    private static void Main(string[] args)
    {
        var debtorApp = new DebtorApp();
        debtorApp.IntroduceDebtorApp();
        debtorApp.AskForAction();
    }
}