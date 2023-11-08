using System;

class Program
{
    //18.Дан массив A. Определить сумму знакочередующейся последовательности A[1] – А[2] + А[3] – A[4] + ... . Условную инструкцию и операцию возведения в степень не использовать.
    static void Main()
    {
        int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int sum = 0;
        bool add = true; // Флаг

        foreach (int number in A)
        {
            if (add)
            {
                sum += number;
            }
            else
            {
                sum -= number;
            }

            add = !add; // Меняем флаг
        }

        Console.WriteLine("Сумма знакочередующейся последовательности: " + sum);
    }
}
