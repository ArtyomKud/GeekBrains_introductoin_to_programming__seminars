/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива. 
Не использовать готовые методы Min и Max

[3 7 22 2 78] -> 76 */

Random random = new Random();
int numberMin = 0;
int numberMax = 30;
int size = 10;

float [] array = GenerateArray(numberMin, numberMax, size);
PrintArray(array);
float differenceBetweenArrayMaxAndArrayMin = FindDifferenceBetweenArrayMaxAndArrayMin(array);
Console.WriteLine(differenceBetweenArrayMaxAndArrayMin);




float [] GenerateArray (int numberMin1, int numberMax1, int size1)
{
    float [] arrayOut = new float [size1];
    for (int i = 0; i < arrayOut.Length; i++)
    {
        arrayOut[i] = Convert.ToSingle(random.Next(numberMin, numberMax + 1)/10.0);
    }
    return arrayOut;
}

void PrintArray (float [] array1)
{
    Console.WriteLine($"[{String.Join("; ", array1)}]");
}

float FindDifferenceBetweenArrayMaxAndArrayMin(float [] inputArray)
{
    
    float min = inputArray[0];
    float max = inputArray[0];
    float differenceOut;
    
    for (int i = 1; i <inputArray.Length; i++)
    {
        if (min > inputArray[i])
        {
            min = inputArray[i];
        }
        if (max < inputArray[i])
        {
            max = inputArray[i];
        }
    }
    differenceOut = max-min;
    return differenceOut;
}