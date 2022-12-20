using System;
using static MyMetods.Class1;

/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */
int sizeMin = 1;
int sizeMax = 50;

int [] userDataSize2DArray = 
InputDataSeparatedSpaceOneLineInteger("Введите количество строк и столбцов массива через пробел: ");
PrintArray(userDataSize2DArray);
try
{
    double[,] result2DArray = Generation2DArray(userDataSize2DArray, sizeMin, sizeMax);
    PrintArray(result2DArray);
    
}
catch (ArgumentException ex)
{
    
    Console.WriteLine(ex.Message);
}

