using System.Xml.Linq;

namespace Deptor.core

{
    public class BorrowerManager
    {
        private List<Borrower> Borrowers { get; set; }
        private string FileName { get; set; } = "borrowers.txt";
        public BorrowerManager()
        {
            Borrowers = new List<Borrower>();

            if (!File.Exists(FileName)) {
                return; 

            }
            var fileLines = File.ReadAllLines(FileName);

            foreach ( var line in fileLines)
            {
                var lineItems = line.Split(';');

                if (decimal.TryParse(lineItems[1], out var decimalValue) )
                {
                    AddBorrower(lineItems[0], decimalValue, false);
                }

              
            }
        }

        public void AddBorrower(string name, decimal amount, bool shouldSaveFile=true)
        {
            var borrower = new Borrower
            {
                Name = name,
                Amount = amount
            };

            Borrowers.Add(borrower);
            if(shouldSaveFile )
            {
                File.WriteAllLines(FileName, new List<string> { borrower.ToString() });
            }
        }
        public void DeleteBorrower(string name, bool shouldSaveToFile = true) 
        {
           foreach (var borrower in Borrowers)
            {
                if (borrower.Name == name)
                {
                    Borrowers.Remove(borrower);
                    break;
                }
            }
           if (shouldSaveToFile)
            {
                var borrowersToSave = new List<string>();

                foreach (var borrower in Borrowers)
                {
                    borrowersToSave.Add(borrower.ToString());
                }

                File.Delete(FileName);
                File.WriteAllLines(FileName, borrowersToSave);
            }

        }
        public List<string> ListBorrowers()
        {
            var borrowersString = new List<string>();
            var indexer = 1;

            foreach (var borrower in Borrowers)
            {

                var borrowerString = $"{indexer}.{borrower.Name} {borrower.Amount} zł";

                indexer++;

                borrowersString.Add(borrowerString);
            }
            return borrowersString;
        }
    }


}
