// Задача 1: 
// Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.


// int PrintNumbers(int x, int y)
// {
//     if (x > y)
//     {
//         Console.Write($"{y}, ");
//         if (x == y)
//         {
//             return (y);
//         }

//         return PrintNumbers(x, y + 1);
//     }
//     Console.Write($"{x}, ");
//     if (x == y)
//     {
//         return (x);
//     }
//     return PrintNumbers(x + 1, y);
// }
// Console.Clear();
// Console.Write("Задайте значение M: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Задайте значение N: ");
// int n = int.Parse(Console.ReadLine()!);
// PrintNumbers(m, n);

// Задача 2: 
// Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

int Ackermann(int m, int n)
{
    if (m < 0 || n < 0)
    {
        return (-1);
    }
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    return (0);
}
void PrintResult(int k)
{
    if (k == -1)
    {
        Console.WriteLine("Значение n и m не могут быть отрицательными числами!");
    }
    else
        Console.WriteLine(k);
}

Console.Clear();
Console.Write("Задайте значение m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Задайте значение n: ");
int n = int.Parse(Console.ReadLine()!);
int k = Ackermann(m, n);
PrintResult(k);

