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

// int Ackermann(int m, int n)
// {
//     if (m < 0 || n < 0)
//     {
//         return (-1);
//     }
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     if (m > 0 && n == 0)
//     {
//         return Ackermann(m - 1, 1);
//     }
//     if (m > 0 && n > 0)
//     {
//         return Ackermann(m - 1, Ackermann(m, n - 1));
//     }
//     return (0);
// }
// void PrintResult(int k)
// {
//     if (k == -1)
//     {
//         Console.WriteLine("Значение n и m не могут быть отрицательными числами!");
//     }
//     else
//         Console.WriteLine(k);
// }

// Console.Clear();
// Console.Write("Задайте значение m: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Задайте значение n: ");
// int n = int.Parse(Console.ReadLine()!);
// int k = Ackermann(m, n);
// PrintResult(k);
// Задача 3: 
// Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

int[] FillingArray(int[] array, int i)
{
    if (i < array.Length)
    {
        array[i] = new Random().Next(1, 100);
        FillingArray(array, i + 1);
    }
    return array;
}

string PrintStartArray(int[] array, int i)
{
    if (i == array.Length - 1)
    {
        return $"{array[array.Length - 1]} ";
    }
    return PrintStartArray(array, i + 1) + $"{array[i]} ";
}

string PrintEndArray(int[] array, int i)
{
    if (i == array.Length - 1)
    {
        return $"{array[array.Length - 1]} ";
    }
    return $"{array[i]} " + PrintEndArray(array, i + 1);
}

Console.Clear();
Console.Write("Задайте количество элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int i = 0;
int[] array = new int[n];
FillingArray(array, i);
Console.WriteLine("Начальный массив: ");
Console.WriteLine(PrintStartArray(array, i));
Console.WriteLine("Конечный массив: ");
Console.WriteLine(PrintEndArray(array, i));
