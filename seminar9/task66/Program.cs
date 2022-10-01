// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void SumMtoN(int m, int n, int sum)
{
    if(n < m)
    {
        sum += m;
        SumMtoN(m - 1, n, sum);
    }
    else if(n > m)
    {
        sum += n;
        SumMtoN(m, n - 1, sum);
    }
    else if(n == m || (m == n - 1) || (n == m - 1)) 
    {
        sum += n;
        Console.WriteLine($"Сумма натуральных чисел в промежутке от M до N: {sum}");
    }
}

int M = ReadNumber("Введите M");
int N = ReadNumber("Введите N");
int summa = 0;
SumMtoN(M, N, summa);
