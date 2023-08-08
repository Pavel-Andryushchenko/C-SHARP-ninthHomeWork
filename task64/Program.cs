// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string GetListNumber (int number)
{
    if (number == 1) return "1";
    return number.ToString() + ", " + GetListNumber(number-1);
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());    
Console.WriteLine($"N = {number} ->{GetListNumber(number)}");