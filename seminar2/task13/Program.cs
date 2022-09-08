// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number;
int k = 1;

while (number1 > 0)
{
    number1 = number1/10;
    k = k*10;
}

if(k > 999)
{
    int res = (number*1000 / k) % 10;
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("третьей цифры нет");
}