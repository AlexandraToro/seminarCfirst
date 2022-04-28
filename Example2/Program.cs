//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число");
int numbA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numbB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numbC = int.Parse(Console.ReadLine());
int Max = numbA;
if (numbB > Max) Max = numbB;
if (numbC > Max) Max = numbC;
{
    Console.WriteLine("Максимальное число " + Max);
}