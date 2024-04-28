using System;
using System.Collections.Generic;
using System.Linq;

// Задание 1. Туристическая фирма
class TourAgency
{
    public string Name { get; set; }
    public int YearFounded { get; set; }
    public string INN { get; set; }
    public double Profit { get; set; }

    public void Initialize(string name, int yearFounded, string inn, double profit)
    {
        Name = name;
        YearFounded = yearFounded;
        INN = inn;
        Profit = profit;
    }

    public string GetInfo()
    {
        return $"Фирма: {Name}\nГод основания: {YearFounded}\nИНН: {INN}\nПрибыль за текущий год: {Profit}\n";
    }
}
