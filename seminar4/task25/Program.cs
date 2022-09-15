// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int ProdNumbersFrom1ToAdegB(int a, int b)
{
    if (a >= 1 && b >= 1) //если А и B больше либо равно 1, то работаем дальше
    {
        int multi = 1;
        for (int i = 1; i <= b; i++)
        {
            multi *= a; //копим произведение
        }
        return multi; //вернем накопившееся произведение
    }
    else
    {
        Console.WriteLine("Числа A и B должны быть не меньше 1!");
        return -1; //неправильная сумма (код ошибки)
    }
}

int numberA = ReadNumber("Введите число:");
int numberB = ReadNumber("Введите натуральную степень:");
int degree = ProdNumbersFrom1ToAdegB(numberA, numberB);
Console.WriteLine($"Число A в степени B = {degree}");