using System;
using static MyMetods.Class1;
/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int [] inputNumbers = InputDataSeparatedSpaceOneLineInteger("Введите через пробел два натуральных числа: ");
PrintArray(inputNumbers);

int numberOne = inputNumbers[0];
int numberTwo = inputNumbers[1];

int result = SummFromMToN(numberOne, numberTwo);
Console.WriteLine(result);

int SummFromMToN (int number1, int number2)
{
     if(number1 - number2 > 0)
    {
        return 0;
    }
    number1 = number1 + SummFromMToN(number1+1, number2);
    
   
   
    return number1;
}