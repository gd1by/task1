using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Bank> banks = new List<Bank>
        {
            new Bank("Bank 1", 27.50, 28.00),
            new Bank("Bank 2", 27.60, 28.10),
            new Bank("Bank 3", 27.45, 27.95),
            // Добавьте другие банки
        };

        double currentExchangeRate = 27.70;
        double maxProfit = 0;
        string bestBank = "";

        foreach (var bank in banks)
        {
            double profit = (bank.SellingRate - currentExchangeRate) * 100;
            if (profit > maxProfit)
            {
                maxProfit = profit;
                bestBank = bank.Name;
            }
        }

        Console.WriteLine($"Лучший банк для обмена: {bestBank}");
        Console.WriteLine($"Максимальная выгода: {maxProfit}%");
    }
}

class Bank
{
    public string Name { get; set; }
    public double BuyingRate { get; set; }
    public double SellingRate { get; set; }

    public Bank(string name, double buyingRate, double sellingRate)
    {
        Name = name;
        BuyingRate = buyingRate;
        SellingRate = sellingRate;
    }
}
