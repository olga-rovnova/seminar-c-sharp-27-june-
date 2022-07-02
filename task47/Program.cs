//Задача 47: Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

int m = Input("введите m: ");
int n = Input("введите n: ");

double[,] numbers = new double[m, n];

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = Math.Round((new Random().Next(100, 1000) * 0.01 + new Random().Next(10)), 2);
    }
}

PrintArray(numbers);

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(double[,] array)
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