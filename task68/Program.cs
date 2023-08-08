// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int GetAkermanFunction(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberN == 0) return GetAkermanFunction(numberM - 1, 1);
    return GetAkermanFunction(numberM - 1, GetAkermanFunction(numberM, numberN - 1));
}

Console.Write("Введите m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM < 0 | numberN < 0) {Console.WriteLine("Функция Аккермана определена для неотрицательных чисел");}
else {Console.WriteLine($"M = {numberM} N = {numberN} -> A({numberM},{numberN}) = {GetAkermanFunction(numberM, numberN)}");}
