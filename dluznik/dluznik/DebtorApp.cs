using Deptor.core;

namespace dluznik
{
    public class DebtorApp
    {
        public BorrowerManager BorrowerManager {  get; set; }   = new BorrowerManager();
        public void IntroduceDebtorApp()
        {
            Console.WriteLine("Hej, witam w aplikacji dłużnik");
        }
        public void AddBorrower()
        {

            Console.WriteLine("Podaj nazwę dłużnika, którego chcesz dodać do listy ");
            var userName = Console.ReadLine();

            decimal amountInDecimal= 0;
            bool isValidAmount = false;

            while (!isValidAmount)
            {
                Console.WriteLine("Podaj kwotę zadłużenia tego dłużnika");
                var userAmount = Console.ReadLine();
                isValidAmount = decimal.TryParse(userAmount, out amountInDecimal);

                if (!isValidAmount)
                {
                    Console.WriteLine("Podano niepoprawną kwotę");
                }
            }


            BorrowerManager.AddBorrower(userName, amountInDecimal);
            
            
        }
        public  void DeleteBorower()
        {
            Console.WriteLine("Podaj nazwę dłużnika, którego chcesz usunąć z listy ");
            var userName = Console.ReadLine();
            
            BorrowerManager.DeleteBorrower(userName);
            Console.WriteLine( "Udało sie usunąć dłużnika");
        }
        public void ListAllBorowe()
        {
            Console.WriteLine("oto lista Twoich dłużników: ");

            foreach (var borrower in BorrowerManager.ListBorrowers())
            {
                Console.WriteLine(borrower);
            }
        }
        public void AskForAction()
        {
            Console.WriteLine("Podaj czynność, którą chcesz wykonać: ");
            var userInput = default(string);

            while (userInput!= "exit")
            {
                Console.WriteLine("add- dodawanie dłużnika");
                Console.WriteLine("del - usunięcie dłużnika");
                Console.WriteLine("list - wypisywanie listy dłużników ");
                Console.WriteLine("exit - wyjście z programu ");

                userInput = Console.ReadLine();
                userInput = userInput.ToLower();

                switch (userInput)
                {
                    case "add":
                        AddBorrower();
                        break;
                    case "del":
                        DeleteBorower();
                        break;     
                    case "list":
                        ListAllBorowe();
                            break;
    
                default:
                        Console.WriteLine("Podano nieobsługiwaną wartość");
                        break;



                }
            }
            
        }
    }
}
