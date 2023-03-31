

// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

void Fillmatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().Next(-100, 111) * 0.1, 1);
        }
    }
}

void Printmatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[rows, cols];
Fillmatrix(matrix);
Printmatrix(matrix);




// / Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет




// void Fillmatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0, 20);
//         }
//     }
// }

// void Printmatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j],3}\t");
//         }
//         Console.WriteLine();
//     }
// }

// void Duul(int[,] matrix, int number)
// {
//     int count = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] == number)
//             {
//                 Console.WriteLine($"{number} -> {number} [{i},{j}]");
//                 count++;
//             }
//         }
//     }
//     if (count > 0)
//             {
//                 Console.WriteLine($"Число {number}, количество вхождений {count}.");
//             }
//     else Console.WriteLine($"{number} --> такого числа в массиве нет.");
// }



// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, cols];

// int number = Convert.ToInt32(Console.ReadLine());

// Fillmatrix(matrix);
// Printmatrix(matrix);
// Duul(matrix, number);




// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.




// void Fillmatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0, 20);
//         }
//     }
// }

// void Printmatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j],3}\t");
//         }
//         Console.WriteLine();
//     }
// }


// double[] Average(int[,] matrix, double[] array, int rows)
// {

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             array[j] += matrix[i, j];
//         }
//     }
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] /= rows;
//         array[i] = Math.Round(array [i],1);
//     }

//     return array;
// }



// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, cols];

// double[] array = new double[cols];

// Fillmatrix(matrix);
// Printmatrix(matrix);
// Console.WriteLine();
// Console.Write(String.Join("\t", Average(matrix, array, rows)));