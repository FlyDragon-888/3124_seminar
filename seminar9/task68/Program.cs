// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadNumber(string message)
{
    int number = -1;
    while(number < 0)
    {
        Console.WriteLine(message);
        number = Convert.ToInt32(Console.ReadLine());
    }
    return number;
}

int FunctionsAckerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    if (m == 0)
    {
        return FunctionsAckerman(n - 1, 1);
    }
    return FunctionsAckerman(n - 1, FunctionsAckerman(n, m - 1));
}

int M = ReadNumber("Введите неотрицательное число M");
int N = ReadNumber("Введите неотрицательное число N");
Console.WriteLine($"A({M},{N}) = {FunctionsAckerman(M, N)}");