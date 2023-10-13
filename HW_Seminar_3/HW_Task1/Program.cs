// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход 
// пятизначное число number и проверяет, является ли оно палиндромом.

// Метод должен проверить является ли число пятизначным, 
// в противном случае - вывести Число не пятизначное и False в следующей строке.

// Для остальных чисел вернуть True или False.

Console.WriteLine("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());

int IsPalindrome(int number)
{
    int remainder, revNumber = 0;
    while(number > 0)
    {
        remainder = number %10;
        number = number /10;
        revNumber = (revNumber * 10) + remainder;
    }
    return revNumber;
}

int result = IsPalindrome(num);

bool Method(int number)
{
if(num == result)
{
    Console.WriteLine($"{num} ->");
    return true;
}
else if(num > 9999 && num <= 99999)
{
    Console.WriteLine($"{num} ->");
    return false;
}
else
{
    Console.WriteLine($"{num} -> Число не пятизначное");
    return false;
}
}
Console.WriteLine(Method(result));






////////////////////////////////////////////////////////////

// bool IsPalindrome(int palindrom)
// {
//     int num1 = palindrom / 10000;
//     int num2 = (palindrom / 1000) % 10;
//     int num4 = (palindrom / 10) % 10;
//     int num5 = palindrom % 10;
//     if(num1 == num5 && num2 == num4)
//         {
//             return true;
//         }
//         else if(palindrom > 9999 && palindrom <= 99999)
//         {
//             Console.WriteLine($"{num} -> ");
//             return false;
//         }
//         else
//         {
//             Console.WriteLine($"{num} -> Число не пятизначное ");
//             return false;
//         }
// }

// bool result = IsPalindrome(num);
// Console.WriteLine(result);

////////////////////////////////////////////////////////////



//       // Введите свое решение ниже
      
    
  
//   // Не удаляйте и не меняйте метод Main! 
//       static public void Main(string[] args) 
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 64546;
//         }

//         // Не удаляйте строки ниже
//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
    

