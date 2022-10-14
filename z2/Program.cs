Console.WriteLine("Vvedite pervoe chislo");
int input=int.Parse(Console.ReadLine()!);
Console.WriteLine("Vvedite vtoroe chislo");
int input2=int.Parse(Console.ReadLine()!);
if(input>input2)
{
    Console.WriteLine($"Max {input} Min {input2}");
}
else
{
  Console.WriteLine($"Max {input2} Min {input}");  
}