// Внутри класса Answer напишите метод ShowCube, 
// который принимает на вход число (N) и 
// выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Сubing(num);

void Сubing(int number)
{
    int count = 1;
    while(count <= number)
    {
        Console.WriteLine($"{count, 3} -> {count * count * count, 5}");
        count++;
    }
}