using System;

partial class Program
{
    static void Main(string[] args)
    {
        int vibor = 0;

        Console.WriteLine("Саламатлы София Алексеевна! Насыпайте чайку и садитесь поудобнее!");
        while (vibor != 4)
        {
            Console.WriteLine("Меню:\n1. Игра \"Угадай число\"\n2. Таблица умножения\n3. Вывод делителей числа\n4. Выход");
            Console.Write("Выберите программу (1-4): ");
            vibor = Convert.ToInt32(Console.ReadLine());

            switch (vibor)
            {
                case 1:
                    ygadayka();
                    break;
                case 2:
                    tablicaumnojenia();
                    break;
                case 3:
                    delitel();
                    break;
                case 4:
                    Console.WriteLine("Алагьза, София Алексеевна!");
                    break;
                default:
                    Console.WriteLine("Вы не много промахнулись");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void ygadayka()
    {
        Random random = new Random();
        int zagadannoechislo = random.Next(0, 101);
        int guess = -1;
        int attempts = 0;

        Console.WriteLine("Игра \"Угадай число\"");
        Console.WriteLine("Я загадал число от 0 до 100. Попробуйте угадать!");

        while (guess != zagadannoechislo)
        {
            Console.Write("Введите число: ");
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (guess < zagadannoechislo)
            {
                Console.WriteLine("Загаданное число больше.");
            }
            else if (guess > zagadannoechislo)
            {
                Console.WriteLine("Загаданное число меньше.");
            }
            else
            {
                Console.WriteLine($"Поздравляю! Вы угадали число {zagadannoechislo} за {attempts} попыток.");
            }
        }
    }

    static void tablicaumnojenia()
    {
        Console.WriteLine("Таблица умножения:");

        int[,] table = new int[10, 10];

        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                table[row, col] = (row + 1) * (col + 1);
            }
        }

        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                Console.Write($"{table[row, col],-4}");
            }
            Console.WriteLine();
        }
    }

    static void delitel()
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Все делители числа {number}:");
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}