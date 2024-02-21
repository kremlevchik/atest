// Задача 1: 
// Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.


int PrintNumbers(int x, int y)
{
    if (x > y)
    {
        Console.Write($"{y}, ");
        if (x == y)
        {
            return (y);
        }

        return PrintNumbers(x, y + 1);
    }
    Console.Write($"{x}, ");
    if (x == y)
    {
        return (x);
    }
    return PrintNumbers(x + 1, y);
}
Console.Clear();
Console.Write("Задайте значение M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Задайте значение N: ");
int n = int.Parse(Console.ReadLine()!);
PrintNumbers(m, n);

