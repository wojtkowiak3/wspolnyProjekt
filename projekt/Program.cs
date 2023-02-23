namespace projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] monthsOfYear =
            {
                "Styczeń",
                "Luty",
                "Marzec",
                "Kwiecieć",
                "Maj",
                "Czerwiec",
                "Lipiec",
                "Sierpień",
                "Wrzesień",
                "Październik",
                "Listopad",
                "Grudzień"
            };

            Console.WriteLine(monthsOfYear[0]);

            foreach (string month in monthsOfYear)
            {
                Console.WriteLine(month);
            }

            foreach (var month in monthsOfYear)
            {
                Console.WriteLine(month);
            }

            Console.Clear();

            Console.WriteLine("1 - styczeń, 2 - luty itd.");
            Console.WriteLine("Podaj numer miesiąca");

            int chosenMonth = int.Parse(Console.ReadLine());
            Console.WriteLine($"Miesiąc: {monthsOfYear[chosenMonth]}");
        }
    }
}