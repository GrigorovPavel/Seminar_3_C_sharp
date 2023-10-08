// Напишите программу, которая
// 1. пинимает на вход координаты точки (X и Y),
// 2. причем X != 0 и Y != 0 и 
// 3. выдает номер четверти плоскости в которой находится эта точка.

int Quarter(int x, int y)  // Метод определяет "четверть" квадрата
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

Console.WriteLine("Введите координату X, больше 0");
int xСoordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y, больше 0");
int yСoordinate = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xСoordinate, yСoordinate); // присваиваем переменной, результат метода
if (xСoordinate == 0 || yСoordinate == 0)
{
    Console.WriteLine("Некорректный ввод.");
}
else
{
    Console.WriteLine($"Указанные координаты соответствуют {quarter}-й четверти");
}
