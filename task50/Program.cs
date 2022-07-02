// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int m = new Random().Next(10);
int n = new Random().Next(10);
int[,] randomNumbers = new int[m, n];
FillArray(randomNumbers);
PrintArray(randomNumbers);

Console.Write("введите целое двузначное число больше 10: ");

int number = Convert.ToInt32(Console.ReadLine());
int number1 = number / 10;
int number2 = number % 10;

if (number > 10 && number < 100)
    if (number1 <= m && number2 <= n)
    {
        Console.WriteLine("значение элемента массива: " + randomNumbers[number1 - 1, number2 - 1]);
    }
    else Console.WriteLine("такого числа в массиве нет");
else Console.WriteLine("введено некорректное число");


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