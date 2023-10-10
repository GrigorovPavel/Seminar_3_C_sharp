// Напишите программу, которая
// 1. принимает на вход координаты двух точек т
// 2. находит расстояние между ними
// A(3,6) B(2,1) -> 5,09
// A(7,-5) B(1,-1) -> 7,21

// Math.Pow(2, 4) - Возвести в степень ( 2 возвести в 4-ю степень)
// Math.Sqrt(9) - Извлечь квадратный корень ( из 9-ти)

Console.WriteLine("Введите координаты x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double res = Distance(x1, y1, x2, y2);

Console.WriteLine($"{Math.Round(res, 2, MidpointRounding.ToZero)}");

double Distance(int xValue1, int yValue1, int xValue2, int yValue2)
{
    double result = Math.Sqrt(Math.Pow((xValue1 - xValue2), 2) + Math.Pow((yValue1 - yValue2), 2));
    return result;
}
