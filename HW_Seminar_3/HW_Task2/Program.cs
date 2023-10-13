// Внутри класса Answer напишите метод DistanceBetweenPoints, 
// который принимает на вход координаты двух точек pointA и pointB 
// в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double res = Distance(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"{Math.Round(res, 2, MidpointRounding.ToZero)}");

double Distance(int xValue1, int yValue1, int zValue1, int xValue2, int yValue2, int zValue2)
{
    double result = Math.Sqrt(Math.Pow((xValue1 - xValue2), 2) + Math.Pow((yValue1 - yValue2), 2) + Math.Pow((zValue1 - zValue2), 2));
    return result;
}

///////////////////////////////////////////////////////////////////////////////////////// или
// Console.WriteLine("Введите координаты x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты x3: ");
// int x3 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты y3: ");
// int y3 = Convert.ToInt32(Console.ReadLine());

// double res = Distance(x1, x2, x3, y1, y2, y3);

// Console.WriteLine($"{Math.Round(res, 2, MidpointRounding.ToZero)}");

// double Distance(int xValue1, int xValue2, int xValue3, int yValue1, int yValue2, int yValue3)
// {
//     double result = Math.Sqrt(Math.Pow((xValue1 - yValue1), 2) + Math.Pow((xValue2 - yValue2), 2) + Math.Pow((xValue3 - yValue3), 2));
//     return result;
// }