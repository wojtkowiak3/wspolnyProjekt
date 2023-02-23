using projekt2.classes;

namespace projekt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string CsvFilePath = "C:\\xampp\\htdocs\\2023_02_23\\wspolnyProjekt\\projekt2\\population.csv";

            CsvReader csvReader = new CsvReader(CsvFilePath);
            City[] cities = csvReader.ReadFirstNCities(3);

            foreach (City city in cities)
            {
                Console.WriteLine("Miasto");
            }
        }
    }
}