﻿// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите X: ");
int X = int.Parse(Console.ReadLine());

Console.Write("Введите Y: ");
int Y = int.Parse(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("I");
}
if (X < 0 && Y > 0)
{
    Console.WriteLine("II");
}
if (X < 0 && Y < 0)
{
    Console.WriteLine("III");
}
if (X > 0 && Y < 0)
{
    Console.WriteLine("IV");
}
