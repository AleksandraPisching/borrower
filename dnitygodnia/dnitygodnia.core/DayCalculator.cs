using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dnitygodnia.core
{
    public class DayCalculator //oblicza dzien tyg
    {
        public DayOfTheWeek CalculateDayOfTheWeek(DateTimeOffset date)
        {

            var day  = date.Day;
            var month = date.Month;
            var year = date.Year;



            var listOfParameters = new List<int> { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
           /* Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            Console.WriteLine($"List of parameters for month {month}: {listOfParameters[month - 1]}"); */

            year -= month < 3 ? 1 : 0; // if "?" wartość dla prawdy w tym wypadku 1 i wartość dla fałszu -> 0

            var calculatedValu = (year + year / 4 - year / 100 + year / 400 + listOfParameters[month - 1] + day) % 7;

            //sprawdzenie czy calculatedValu jest mniejsze od 0
            if (calculatedValu <= 0)
            {
                calculatedValu += 7; //Dodanie 7, aby wartość mieściła się w zakresie od 0 do 6
            }

            // Console.WriteLine("Obliczona wasrtość calculatedValu: " + calculatedValu);

            return (DayOfTheWeek)(calculatedValu-1);
        }

    }
}
