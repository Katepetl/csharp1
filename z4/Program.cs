
        // Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
        // Пример 2, 3, 7 -> 7
        Console.WriteLine("Vvedite pervoe chislo");
        int a = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Vvedite vtoroe chislo");
        int b = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Vvedite tret'e chislo");
        int c = int.Parse(Console.ReadLine()!);
        int max = a;
        if (b > a)
        {
            max=b;
        }
        if (c>max)
        {
             max=c;
        }

Console.WriteLine($"Max {max}");