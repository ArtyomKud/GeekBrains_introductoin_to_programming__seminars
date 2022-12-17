/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */
Random random = new Random();

int numberMin = 100;
int numberMax = 999;
int size = 4;

int [] array = GenerateArray(numberMin, numberMax, size);

PrintArray(array);

int amountDivideTo2Numbers = CheckAmountDivideTo2Numbers(array);

Console.WriteLine(amountDivideTo2Numbers);





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

int CheckAmountDivideTo2Numbers(int [] inputArray)
{
    int count = 0;
    for (int i = 0; i <inputArray.Length; i++)
    {
        if (inputArray[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}