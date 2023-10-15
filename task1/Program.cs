using System;

class Program
{
    static void Main()
    {
        int[] bal = { 80, 90, 75, 60, 95, 85, 70, 78, 88, 92 }; // Масив балів у десяти видів спорту
        int porog = 800; // Порогове значення для виходу в наступний етап

        int sumb = 0;

        foreach (int ball in bal)
        {
            sumb += ball;
        }

        if (sumb > porog)
        {
            Console.WriteLine("Спортсмен проходить в наступний етап соревнований.");
        }
        else
        {
            Console.WriteLine("Спортсмен не проходить в наступний етап соревнований.");
        }
    }
}
