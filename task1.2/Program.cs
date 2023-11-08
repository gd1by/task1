using System;
using System.Collections.Generic;

class Program
{
/*43.У вас есть доллары. Вы хотите обменять их на гривны.
Есть информация о стоимости купли-продажи в банках города. 
    В городе N банков. Составьте программу, определяющую, 
    какой банк выбрать, чтобы выгодно обменять доллары на гривны.*/
    static void Main()
    {
        // Створення списку банків з валютними курсами
        List<Bank> banks = new List<Bank>
        {
            new Bank("Bank 1", 27.50, 28.00),
            new Bank("Bank 2", 27.60, 28.10),
            new Bank("Bank 3", 27.45, 27.95),
        };

        double currentExchangeRate = 27.70; // Поточний обмінний курс
        double maxProfit = 0; // Змінна для збереження максимальної вигоди
        string bestBank = ""; // Змінна для збереження найкращого банку

        // Перевіряємо кожен банк у списку
        foreach (var bank in banks)
        {
            // Розраховуємо вигоду для кожного банку
            double profit = (bank.SellingRate - currentExchangeRate) * 100;

            // Порівнюємо вигоду з максимальною вигодою
            if (profit > maxProfit)
            {
                maxProfit = profit; // Оновлюємо максимальну вигоду
                bestBank = bank.Name; // Запам'ятовуємо назву найкращого банку
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
