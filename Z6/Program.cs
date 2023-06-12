// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.Clear();
Console.Write($"Введите число a:");
int a = int.Parse (Console.ReadLine());
Console.Write($"Введите число b:");
int b = int.Parse (Console.ReadLine());
Console.Write($"Введите число c:");
int c = int.Parse (Console.ReadLine());
if (a%2==0)
{Console.WriteLine($"Четное число a = {a}");}
if (b%2==0)
{Console.WriteLine($"Четное число b = {b}");}
if (b%2==0)
{Console.WriteLine($"Четное число c = {c}");}