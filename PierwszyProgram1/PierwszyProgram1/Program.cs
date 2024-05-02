internal class Program
{
   
    private static void Main(string[] args)
    {
        var filePath = "imiona.txt"; // ścieżka do plik

        if (File.Exists(filePath))
        {


            // sprawdź, czy mamy zapisane jakieś nazwisko\

            var fileContect = File.ReadAllText(filePath); // file.readalltext() -> w formie stringa,
                                                          // ma " string path" czyli musimy podać ścieżkę do pliku w nawiasach
                                                          // teraz w zmiennej fileContent będzie zawartość pliku
                                                          // żeby spraswdzić czy coś tam jest możemy po prostu zapytać czy są jakieś znaki wpisane w plik
                                                          // jeżeli jest 0 to nic nie ma w pliku, jeżeli jest <= 1 tzn, ze coś tam jest wpisane

            if (fileContect.Length > 0)
            {
                // MAMY IMIE
                // Jeśli tak, wypisujemy i pytamy o usunięcie
                //          Jeśli usunął, wczytujemy nowe
                //          Jeśli nie usunął, kończymy program
                Console.WriteLine("imie zapisane to: " + fileContect);
                Console.WriteLine("Czy chcesz usunąć te imie?");


                var userAnswer = Console.ReadLine();
                if (userAnswer == "Tak")
                {
                    // jeśli usunął, wczytujemy nowe
                    File.Delete(filePath);
                }
                else
                {
                    Console.WriteLine("Podaj imie");
                    var userName = Console.ReadLine();
                    // zapisujemy do pliku
                    File.WriteAllText(filePath, userName);
                    // kończymy program
                    return;
                }
            }

        }

        else
        {

            //NIE MAMY IMIENIA

            // Jeśli nie, wczytujemy i zapisujemy 
            Console.WriteLine("Podaj imie");
            var userName = Console.ReadLine();
            // zapisujemy do pliku
            File.WriteAllText(filePath, userName);


            // ta funkcja przyjmuje path, który jest ustalony wcześniej i zawartość
            // czyli gdzie zapisać - path
            // zawartoś jaką mamy zapisać, w tym wypadku zmienną "imie", którą nam podał użytkownik                
        }



        }

    
}