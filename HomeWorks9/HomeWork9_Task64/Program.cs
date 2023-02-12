using System;
using static MyMetods.Class1;

/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/


int inputNumber = 1;
while(true)
{

    Console.Write("Введите натуральное число: ");
    bool isParse = int.TryParse(Console.ReadLine(), out int inputNumberTemp);
    if (isParse)
    {
        inputNumber = inputNumberTemp;
        break;
    }
    
}
Console.WriteLine(inputNumber);
PrintNumbersFrom1ToN(inputNumber);

void PrintNumbersFrom1ToN (int inputNumberTemp2)
{
    if(inputNumberTemp2 < 1)
    {
        Console.WriteLine("Число не является натуральным!!!");
        return;
    }
    inputNumberTemp2-=1;
    if(inputNumberTemp2<=1)
    {
        return;

    }
    Console.Write(inputNumberTemp2 + " ");
    PrintNumbersFrom1ToN(inputNumberTemp2);


}


