/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int number = InputData();
Console.WriteLine(number);

int [] cubicNumbers = FindingSeriesOfNumbersAndRaisingCube(number);

printArray(cubicNumbers);



int InputData()
{
    bool stopCycle = false;
    int inputNumber = -1;

    while (!stopCycle)
    {
        Console.Write("Введите целое положительное число больше 0: ");
        bool isParse = int.TryParse(Console.ReadLine(), out int inputNumber2);
        if(isParse && inputNumber2 > 0)
        {
            stopCycle = true;
            inputNumber = inputNumber2;
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели некорректное число");
            
        }
        
    }
    return inputNumber;
    
}

int [] FindingSeriesOfNumbersAndRaisingCube (int imputNumber)
{
    int [] array = new int [imputNumber];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = (int)((Math.Pow(i+1,3)));
    }
    return array;
}


void printArray (int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");

    }
}