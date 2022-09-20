// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GetArray(int size,int leftRange,  int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

int GetEvenNumbers(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0)
        {
            sum += 1;
        }
    }
    return (sum);
}

Random rand = new Random();
int[] array = GetArray(4, 100, 999);
Console.WriteLine(string.Join(", ", array));
int n = GetEvenNumbers(array);
Console.WriteLine($"Количество чётных чисел в массиве = {n}");