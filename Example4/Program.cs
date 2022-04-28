// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine ("Введите число ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine ("Список четных чисел от 1 до введенного числа");
int i = 2;
while (i <= N)
{int d = i%2;
if (d == 0)  
{
Console.Write(i + " ");
}
i++;
}