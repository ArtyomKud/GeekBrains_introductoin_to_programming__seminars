using System;
using static MyMetods.Class1;

/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int [] amountLinesAndColumns = {4, 4};
int sizeMin = 1;
int sizeMax = 10;

try
{
    int [,] array2DRandom = Generation2DArrayInteger(amountLinesAndColumns, sizeMin, sizeMax);
    PrintArray(array2DRandom);
    double [] result = AverageColumn(array2DRandom);
    Console.Write($"среднее арифметическое элементов в каждом столбце: ");
    PrintArray(result);
    
    
}
catch (ArgumentException ex)
{
    
    Console.WriteLine(ex.Message);
}

double [] AverageColumn(int [,] inpuArray)
{
    double [] outputArray = new double [inpuArray.GetLength(1)];
    double [] tempOutputArray = new double [inpuArray.GetLength(1)];
    for(int j = 0; j < inpuArray.GetLength(1); j++)
    {
        for(int i = 0; i < inpuArray.GetLength(0); i++)
        {
            tempOutputArray[j] += inpuArray[i,j];
        }
    }

    for(int i = 0; i < tempOutputArray.Length; i++)
    {
        outputArray[i] = tempOutputArray[i]/inpuArray.GetLength(0);
    }
    return outputArray;
    

}
