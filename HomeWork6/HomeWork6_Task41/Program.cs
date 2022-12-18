using static MyMetods.Class1;

/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */





int [] inputData = InputDataSeparatedSpaceOneLineInteger();


PrintArray(inputData);

int result = SummPositiveNumber(inputData);
Console.WriteLine(result);

    