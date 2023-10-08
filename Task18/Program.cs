// Напишем программу, которая
// 1. по заданному номеру четверти,
// 2. показывает диапозон координат точек в этой четверти (X и Y)
//
string Quarter(int num)
{
    if(num == 1) return "X > 0 , Y > 0 ";
    if(num == 2) return "X < 0 , Y > 0 ";
    if(num == 3) return "X < 0 , Y < 0 ";
    if(num == 4) return "X > 0 , Y < 0 ";
    else
    {
    return "Четверти с таким номером нет.";
    }
}

Console.WriteLine("Введите номер четверти от 1 до 4: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string result = Quarter(quarter);
Console.WriteLine(result);

