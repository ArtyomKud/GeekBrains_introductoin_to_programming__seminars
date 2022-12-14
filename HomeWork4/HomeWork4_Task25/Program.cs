/* Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и метод который возводит число A 
в натуральную степень B. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. 
Не использовать Math.Pow() */


int [] numbers = InputData();

double receivedNumber = Exponentiation(numbers);
Console.WriteLine(receivedNumber);


int [] InputData()
{
    bool stopCycle = false;
    int [] inputNumbers = new int [2];

    for(int i = 0, j = 1; i <inputNumbers.Length; i++, j++)
    {
    

    while (!stopCycle)
    {
        Console.Write($"Введите число {j}: ");
        bool isParse = int.TryParse(Console.ReadLine(), out int inputNumber);
        if(isParse)
        {
            stopCycle = true;
            inputNumbers[i] = inputNumber;
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели некорректное число");
            
        }
        
    }
    stopCycle = false;
    }
    return inputNumbers;
    
}

void printArray (int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ,");

    }
}


double Exponentiation (int [] array)
{
    double result = array[0];
    if (array.Length != 2)
    {
        return 0;
    }
    if (array[1] == 0)
    {
        return 1;
    }

    if (array[1] < 0)
    {
        int numberDegre = array[1]*(-1);
        for (int i = 1; i < numberDegre; i++)
        {
            result = result*array[0];
        }
        result = 1/result;
    
    }
    else
    {
        for (int i = 1; i < array[1]; i++)
        {
            result = result*array[0];
        }
    
    }
    
    
    return result;

}