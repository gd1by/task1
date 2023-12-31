using System;

class Program
{
 /*18.Дан массив A. Определить сумму знакочередующейся последовательности A[1] – А[2] + А[3] – A[4] + ... . 
    Условную инструкцию и операцию возведения в степень не использовать.*/
    static void Main()
    {
        int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int sum = 0;     // Змінна для збереження суми
        bool add = true; // Флаг для визначення чи додавати чи віднімати

        foreach (int number in A)
        {
            if (add)
            {
                sum += number; // Додаємо число до суми, якщо флаг вказує на додавання
            }
            else
            {
                sum -= number; // Віднімаємо число від суми, якщо флаг вказує на віднімання
            }

            add = !add; // Змінюємо флаг, щоб перейти до наступного операції додавання або віднімання
        }

        Console.WriteLine("Сумма знакочередующейся последовательности: " + sum);
    }
}
