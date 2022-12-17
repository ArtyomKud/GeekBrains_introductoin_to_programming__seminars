/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */


double [] numbers = InputData();


PrintArray(numbers);






double [] InputData()
{
         
    Console.Write("Введите не более 8 чисел через пробел: ");
    
    String inputData = Console.ReadLine();
    String temp;
    String [] arrayString = new String [inputData.Length];
    int count = 0;
    char chack = ' ';
    for(int i = 0; i < arrayString.Length; i++)
    {
        bool stop = true;
        
        
        while (stop)
        {
            if (count >= inputData.Length)
            {
                stop = false;
                break;
            }
            
            if (inputData[count].Equals(chack))
            {
                
                
                stop = false;
            
                
        
            }
            else 
            {
                temp = arrayString[i];
                arrayString[i] = temp+inputData[count];

            }
            count++;
            
        }
        
        
        
    }
    
    double [] tempOutData = new double [arrayString.Length];
    int count2 = 0;

    for (int i = 0; i < tempOutData.Length; i++)
    {
        bool isParse = double.TryParse(arrayString [i], out double inputNumber);
        if (isParse)
        {
            tempOutData[i] = inputNumber;
        }
        if (inputNumber !=0)
        {
            count2++;
        }

    }
    
    int size = count2;
    if(size > 8)
    {
        size = 8;
    }
    double [] outData = new double [size];

    for (int i = 0; i<outData.Length & i <8; i++)
    {
        outData[i] = tempOutData[i];
    }

    return outData;

      
    
    
}

void PrintArray (double [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");

    }
    Console.WriteLine();
}