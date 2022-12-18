using System;
using static MyMetods.Class1;

/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

int [] inputData = InputDataSeparatedSpaceOneLineInteger("Введите через пробел значения для переменных b1 k1 b2 k2: ");
PrintArray(inputData);

try
{
    double [] intersectionPoint = FindIntersectionPoint(inputData);
    PrintArray(intersectionPoint);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}




double [] FindIntersectionPoint(int [] array)
{
    if(array.Length < 4)
    {
        throw new ArgumentException("Переменных недостаточно!!!");
        
    }
    double b1 = array[0];
    double k1 = array[1];
    double b2 = array[2];
    double k2 = array[3];
    double [] outputArray = new double [2];
    outputArray[0] = ((b2-b1)/(k1-k2));
    outputArray[1] = k2*outputArray[0]+b2;
    return outputArray;

}
