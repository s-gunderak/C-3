// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// AB = √AC2 + BC2

Console.Write("Введите координату X точки A: ");
int AX = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y точки A: ");
int AY = int.Parse(Console.ReadLine());

Console.Write("Введите координату X точки B: ");
int BX = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y точки B: ");
int BY = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(BX - AX, 2) + Math.Pow(BY - AY, 2));
Console.WriteLine($"Расстояние между точками A и B равно {distance}");
