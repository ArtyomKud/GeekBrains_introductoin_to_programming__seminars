/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных индексах.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

Random random = new Random();
int numberMin = 10;
int numberMax = 30;
int size = 10;

int [] array = GenerateArray(numberMin, numberMax, size);
PrintArray(array);
int sumNumbers = FindSumElementOfOddIndices(array);
Console.WriteLine(sumNumbers);




int [] GenerateArray (int numberMin1, int numberMax1, int size1)
{
    int [] arrayOut = new int [size1];
    for (int i = 0; i < arrayOut.Length; i++)
    {
        arrayOut[i] = random.Next(numberMin, numberMax + 1);
    }
    return arrayOut;
}

void PrintArray (int [] array1)
{
    Console.WriteLine($"[{String.Join(" ,", array1)}]");
}

int FindSumElementOfOddIndices(int [] inputArray)
{
    int summOut = 0;
    for (int i = 0; i <inputArray.Length; i++)
    {
        if (i%2 != 0)
        {
            summOut += inputArray[i];
        }
    }
    return summOut;
}