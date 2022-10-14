// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
Console.WriteLine("Vvedite chislo");
int N=int.Parse(Console.ReadLine()!);
int start = 1;
for (int i =start; i<N; i++)
if (i%2==0)
{
    Console.WriteLine(i);
}
