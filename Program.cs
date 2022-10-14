// See https://aka.ms/new-console-template for more information
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Example a = 5; b = 7 -> max = 7

Console.WriteLine("vvedite  chislo");
int input=int.Parse(Console.ReadLine()!);
Console.WriteLine("vvedite drugoe chislo");
int input2=int.Parse(Console.ReadLine()!);
if (input>input2) 
{
    Console.WriteLine($"Max {input} Min {input2}");  
}
else
{
    Console.WriteLine($"Max {input2} Min {input}");
}
    
    
    
    