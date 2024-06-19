using System;

class Program
{
    static void Main()
    {
        // Запрос суммы вклада
        Console.Write("Введите сумму вклада: ");
        decimal deposit = Convert.ToDecimal(Console.ReadLine());

        // Запрос количества месяцев
        Console.Write("Введите количество месяцев: ");
        int months = Convert.ToInt32(Console.ReadLine());

        // Процентная ставка
        decimal interestRate = 0.07m;

        // Расчет суммы с начисленными процентами за каждый месяц
        for (int i = 0; i < months; i++)
        {
            deposit += deposit * interestRate;
        }

        // Вывод результата
        Console.WriteLine($"Конечная сумма вклада с начисленными процентами: {deposit:F2}");
    }
}
