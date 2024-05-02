using dnitygodnia.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dnitygodnia
{
    public class DayGuesser
    {
        public DayCalculator Calculator { get; set;}

        public DateTimeOffset UserDateOfBirth { get; set; }

        public DayOfTheWeek UserDayOfTheWeek { get; set; }

        public void IntroduceTheApp()
        {
            Console.WriteLine("jestem botem, ktory potrafi wyliczać dzien tyg. z Twojej daty urodzenia");
            Calculator = new DayCalculator();

            /*var date1 = new DateTimeOffset(new DateTime(1998,5,31), TimeSpan.Zero);
            var date2 = new DateTimeOffset(new DateTime(2022,7,5),TimeSpan.Zero);

            var dayOfTheWeek1 = Calculator.CalculateDayOfTheWeek(date1);
            var dayOfTheWeek2 = Calculator.CalculateDayOfTheWeek(date2);

            Console.WriteLine("Dla daty "+ date1 + "dzień tygodnia to: "+ dayOfTheWeek1);
            Console.WriteLine("Dla daty "+ date2 + "dzień tygodnia to: "+ dayOfTheWeek2);*/
        }
        public void AskUserForTheirBirthDate()
        {
            Console.WriteLine("PODAJ SWOJĄ DATE URODZENIA");
            var userDate = Console.ReadLine();

            var succeded = DateTimeOffset.TryParse(userDate,out var date);
            if (succeded)
            {
                UserDateOfBirth = date;
                return;
            }
            
             Console.WriteLine("Format daty był zły, proszę podać w mm/dd/yyyy");
             AskUserForTheirBirthDate();
        }
        public void CalculateDayOfTheWeek()
        {
            if (UserDateOfBirth == null)
            {
                Console.WriteLine("Próbowano obliczyć dzień tygodnia bez podania daty");
                return;
            }
            UserDayOfTheWeek = Calculator.CalculateDayOfTheWeek(UserDateOfBirth);
        }
        
        public void PrintBirthDate()
        {
            Console.WriteLine("OBLICZONY DZIEN TYG TO :"  + UserDayOfTheWeek.ToPolishString());
            
        }
    }
}