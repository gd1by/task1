using System;

class Program
{
    static void Main()
    {
        int[] a = { 2, -3, 5, 0, -7 }; // Замените этот массив на свои данные
        int[] b = { 10, 20, 30, 40, 50 }; // Замените этот массив на свои данные

        if (a.Length == b.Length)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] <= 0)
                {
                    b[i] *= 10;
                }
                else
                {
                    b[i] = 0;
                }
            }

            Console.WriteLine("Преобразованный массив b:");
            foreach (int value in b)
            {
                Console.Write(value + " ");
            }
        }
        else
        {
            Console.WriteLine("Длины массивов a и b должны совпадать.");
        }
    }
}
