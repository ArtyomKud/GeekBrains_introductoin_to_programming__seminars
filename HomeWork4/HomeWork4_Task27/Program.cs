/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */


int number = InputData();

int summ = SummNumbers(number);
Console.WriteLine(summ);



int InputData()
{
    bool stopCycle = false;


    while (!stopCycle)
    {
        Console.Write("Введите число: ");
        bool isParse = int.TryParse(Console.ReadLine(), out int inputNumber);
        if(isParse)
        {
            stopCycle = true;
            return inputNumber;
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели некорректное число");
            
        }
        
    }
    return 0;
    
}

int SummNumbers (int numberToSumm) 
{
    int result = 0;
    if(numberToSumm<0)
    {
        numberToSumm *= -1;
    }
    
    
    if(numberToSumm<10 | numberToSumm == 0)
    {
        return numberToSumm;
    }

    double temp = numberToSumm;
    int dev = 1;
    int count = 1;

    while(temp > 9)
    {
        temp = temp/10;
        dev = dev*10;
        count++;
    }


    int[] arrayNumberToSumm = new int [count];

    for(int i = 0; i < arrayNumberToSumm.Length; i++)
    {
        arrayNumberToSumm[i] = numberToSumm/dev;
        numberToSumm = numberToSumm-arrayNumberToSumm[i]*dev;

        dev = dev/10;
    }
    

    for(int i = 0; i < arrayNumberToSumm.Length; i++)
    {
        result += arrayNumberToSumm[i];
    }

    
    
    return result;


}
