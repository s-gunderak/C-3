// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine());

if (quarter == 1)
{
    Console.WriteLine("Диапазон возможных координат от X > 0 до Y > 0");
}
else if (quarter == 2)
{
    Console.WriteLine("Диапазон возможных координат от X < 0 до Y > 0");
}
else if (quarter == 3)
{
    Console.WriteLine("Диапазон возможных координат от X < 0 до Y < 0");
}
else if (quarter == 4)
{
    Console.WriteLine("Диапазон возможных координат от X > 0 до Y < 0");
}
else
{
    Console.WriteLine("Введите номер четверти в диапазоне от 1 до 4 включительно");
}