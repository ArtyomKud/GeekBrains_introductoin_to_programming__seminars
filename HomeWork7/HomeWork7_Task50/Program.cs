using System;
using static MyMetods.Class1;

/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */
int [] amountLinesAndColumns = {4, 4};
int sizeMin = -10;
int sizeMax = 10;

int [] positionUsers = InputDataSeparatedSpaceOneLineInteger("Введите номер строчки и столбца через пробел: ");


try
{
    int [,] array2DRandom = Generation2DArrayInteger(amountLinesAndColumns, sizeMin, sizeMax);
    PrintArray(array2DRandom);
    String result = SearchForValueByPosition(array2DRandom, positionUsers, out int meaning);
    Console.WriteLine($"{result} {meaning}");
    
}
catch (ArgumentException ex)
{
    
    Console.WriteLine(ex.Message);
}

