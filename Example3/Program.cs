// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine ("Введите число ");
int number = int.Parse(Console.ReadLine());
int d = number%2;
if  (d == 0)  
{
Console.WriteLine (number + " является четным числом");
}
else
{
    Console.WriteLine (number + " является нечетным числом");
}