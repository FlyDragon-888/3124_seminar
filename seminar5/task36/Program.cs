// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int GetSumNumbers(int[] arr)
{
    int sum = 0;
    for(int i = 1; i < arr.Length; i+=2)
    {
        sum += arr[i];
    }
    return (sum);
}

Random rand = new Random();
int[] array = GetArray(4, -100, 100);
Console.WriteLine(string.Join(", ", array));
int n = GetSumNumbers(array);
Console.WriteLine($"Cумма элементов массива, стоящих на нечётных позициях = {n}");