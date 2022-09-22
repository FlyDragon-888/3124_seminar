// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

int[] arr = new int[4];
for(int i = 1; i <= 3; i++)
{
    Console.WriteLine($"Длина {i}-й стороны треугольника:");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

if(arr[1] + arr[2] > arr[3] && arr[2] + arr[3] > arr[1] && arr[1] + arr[3] > arr[2])
{
    Console.WriteLine("Треугольник существует");
}
else
{
    Console.WriteLine("Треугольник не существует");
}