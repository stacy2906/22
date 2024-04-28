class Program
{
    static void Main()
    {
        List<TourAgency> agencies = new List<TourAgency>();

        // Добавление информации о туристических фирмах в коллекцию
        agencies.Add(new TourAgency { Name = "Agency1", YearFounded = 2000, INN = "123456", Profit = 50000 });
        agencies.Add(new TourAgency { Name = "Agency2", YearFounded = 1995, INN = "654321", Profit = 70000 });

        // Поиск информации о заданной фирме
        TourAgency selectedAgency = agencies.FirstOrDefault(x => x.Name == "Agency1");
        if (selectedAgency != null)
        {
            Console.WriteLine($"ИНН фирмы '{selectedAgency.Name}': {selectedAgency.INN}\nПрибыль за текущий год: {selectedAgency.Profit}");
        }

        // Поиск суммарной прибыли всех фирм
        double totalProfit = agencies.Sum(x => x.Profit);
        Console.WriteLine($"Суммарная прибыль всех фирм: {totalProfit}");

        // Поиск фирмы с наибольшей прибылью
        TourAgency maxProfitAgency = agencies.OrderByDescending(x => x.Profit).FirstOrDefault();
        Console.WriteLine($"Фирма с наибольшей прибылью: {maxProfitAgency.Name}, Прибыль: {maxProfitAgency.Profit}");

        // Удаление информации об обанкротившейся фирме
        agencies.RemoveAll(x => x.Name == "BankruptAgency");

        // Добавление информации о новой фирме
        TourAgency newAgency = new TourAgency { Name = "NewAgency", YearFounded = 2010, INN = "7890", Profit = 60000 };
        agencies.Add(newAgency);

        // Сортировка фирм по прибыли за текущий год
        agencies = agencies.OrderBy(x => x.Profit).ToList();

        // Вывод информации о всех фирмах
        foreach (TourAgency agency in agencies)
        {
            Console.WriteLine(agency.GetInfo());
        }
    }
}
