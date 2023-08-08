// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSumNumbers (int startNumber, int finishNumber)
{
    if (startNumber > finishNumber) return 0;
    return startNumber + GetSumNumbers(startNumber + 1, finishNumber);
}

Console.WriteLine("Введите N:");
int startNumber = Convert.ToInt32(Console.ReadLine());  
Console.WriteLine("Введите M:");
int finishNumber = Convert.ToInt32(Console.ReadLine());   
Console.WriteLine($"M = {startNumber} N = {finishNumber} -> {GetSumNumbers(startNumber, finishNumber)}");