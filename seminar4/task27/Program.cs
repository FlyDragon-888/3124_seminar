// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetCountOfDigits(int num)
{
    int sum = 0; //сумма цифр
    while(num != 0)
    {
        sum += num%10;
        num = num / 10;  
    }
    return sum;
}

int number = ReadNumber("Введите число:");
int sum = GetCountOfDigits(number);
Console.WriteLine(sum);