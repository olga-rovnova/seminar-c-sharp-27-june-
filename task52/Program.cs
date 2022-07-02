// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int m = new Random().Next(10);
int n = new Random().Next(10);
int[,] randomNumbers = new int[m, n];
FillArray(randomNumbers);
PrintArray(randomNumbers);

int sum = 0;
double element = 0;
double[] average = new double[n];

for (int j = 0; j < randomNumbers.GetLength(1); j++)
{
    for (int i = 0; i < randomNumbers.GetLength(0); i++)
    {
        sum = sum + randomNumbers[i, j];
        element = sum / randomNumbers.GetLength(0) + (sum * 10 / randomNumbers.GetLength(0)) % 10 * 0.1;
        average[j] = element;
    }
    //Console.WriteLine(sum);
    //Console.WriteLine(element);
    sum = 0;
}

Console.Write("Среднее арифметическое каждого столбца: ");
PrintAverage(average);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
        Console.WriteLine();
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintAverage(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i + 1 < array.Length)
        {
            Console.Write("; ");
        }
        else Console.Write(".");
    }
}