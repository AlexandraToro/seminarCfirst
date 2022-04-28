//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
int numbA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numbB = int.Parse(Console.ReadLine());
if (numbA > numbB) 
{
    Console.WriteLine("Первое число больше второго");
}
else 
{
    Console.WriteLine("Второе число больше первого");
}