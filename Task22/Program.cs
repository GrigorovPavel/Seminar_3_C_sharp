// Написать программу, которая 
// 1. Принимает на вход число (N) и
// 2. выдает таблицу квадратов чисел от 1 до N

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

TableSquare(num);

void TableSquare(int number)
{
    int count = 1;
    while(count <= number)
    {
        Console.WriteLine($"{count, 3} -> {count * count, 5}");
        count++;
    }
}