namespace MyMetods;
public static class Class1


{
    // Печать массива интов
    public static void PrintArray (int [] array1)
    {
        Console.WriteLine($"[{String.Join(" ,", array1)}]");
    }

    // Печать массива даблов
    public static void PrintArray (double [] array1)
    {
        Console.WriteLine($"[{String.Join(" ,", array1)}]");
    }

    public static void PrintArray (String [] array1)
    {
        Console.WriteLine($"[{String.Join(" ,", array1)}]");
    }

    // Печать 2D массива даблов
    public static void PrintArray (double [,] array1)
    {
        for (int i = 0; i <array1.GetLength(0); i++)
        {
            for (int j = 0; j < array1.GetLength(1); j++)
            {
                Console.Write(array1[i,j]+" " );

            }
            Console.WriteLine();
        }
        
    }



    // Получение данных (дабл) от пользователя через консоль в одну строчку через пробел
    public static double [] InputDataSeparatedSpaceOneLineDouble()
    {
         
        Console.Write("Введите числа через пробел: ");
    
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
    
        int count2 = 0;
        bool isParse;
        for (int i = 0; i < arrayString.Length; i++)
        {
            isParse = double.TryParse(arrayString [i], out double inputNumber);
            if (isParse)
            {
                count2++;
            }
        
        }

        double [] tempOutData = new double [count2];

        for (int i = 0, j = 0; i < tempOutData.Length & j < arrayString.Length; i++, j++)
        {
            isParse = double.TryParse(arrayString [j], out double inputNumber);
            if (isParse)
            {
                tempOutData[i] = inputNumber;
                
            }
         else
            {
            j++;
            isParse = double.TryParse(arrayString [j], out double inputNumber2);
            tempOutData[i] = inputNumber2;
            }
        
        }

        return tempOutData; 
    
    }

    // Получение данных (дабл) от пользователя через консоль в одну строчку через пробел с передачей сообщений в метод
    public static double [] InputDataSeparatedSpaceOneLineDouble(String message)
    {
         
        Console.Write(message);
    
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
    
        int count2 = 0;
        bool isParse;
        for (int i = 0; i < arrayString.Length; i++)
        {
            isParse = double.TryParse(arrayString [i], out double inputNumber);
            if (isParse)
            {
                count2++;
            }
        
        }

        double [] tempOutData = new double [count2];

        for (int i = 0, j = 0; i < tempOutData.Length & j < arrayString.Length; i++, j++)
        {
            isParse = double.TryParse(arrayString [j], out double inputNumber);
            if (isParse)
            {
                tempOutData[i] = inputNumber;
                
            }
         else
            {
            j++;
            isParse = double.TryParse(arrayString [j], out double inputNumber2);
            tempOutData[i] = inputNumber2;
            }
        
        }

        return tempOutData; 
    
    }


    // Получение данных (инт) от пользователя через консоль в одну строчку через пробел с передачей сообщения в метод
    public static int [] InputDataSeparatedSpaceOneLineInteger(String message)
    {
         
        Console.Write(message);
    
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
    
        int count2 = 0;
        bool isParse;
        for (int i = 0; i < arrayString.Length; i++)
        {
            isParse = int.TryParse(arrayString [i], out int inputNumber);
            if (isParse)
            {
                count2++;
            }
        
        }

        int [] tempOutData = new int [count2];

        for (int i = 0, j = 0; i < tempOutData.Length & j < arrayString.Length; i++, j++)
        {
            isParse = int.TryParse(arrayString [j], out int inputNumber);
            if (isParse)
            {
                tempOutData[i] = inputNumber;
                
            }
         else
            {
            j++;
            isParse = int.TryParse(arrayString [j], out int inputNumber2);
            tempOutData[i] = inputNumber2;
            }
        
        }

        return tempOutData; 
    
    }


    // Получение данных (инт) от пользователя через консоль в одну строчку через пробел
    public static int [] InputDataSeparatedSpaceOneLineInteger()
    {
         
        Console.Write("Введите числа через пробел: ");
    
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
    
        int count2 = 0;
        bool isParse;
        for (int i = 0; i < arrayString.Length; i++)
        {
            isParse = int.TryParse(arrayString [i], out int inputNumber);
            if (isParse)
            {
                count2++;
            }
        
        }

        int [] tempOutData = new int [count2];

        for (int i = 0, j = 0; i < tempOutData.Length & j < arrayString.Length; i++, j++)
        {
            isParse = int.TryParse(arrayString [j], out int inputNumber);
            if (isParse)
            {
                tempOutData[i] = inputNumber;
                
            }
         else
            {
            j++;
            isParse = int.TryParse(arrayString [j], out int inputNumber2);
            tempOutData[i] = inputNumber2;
            }
        
        }

        return tempOutData; 
    
    }

    // Подсчет положительных чисел в массиве
    public static int SummPositiveNumber(int [] array)
    {
        int count = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] > 0)
            {
                count++;
            }
        }
        return count;
    }

    // Создание двухмерного массива размерами от пользователя и заполняющий рандомными вещественными числами
    public static double [,] Generation2DArray(int [] numberLinesAndColumns, int numberMin, int numberMax)
    {
        if (numberLinesAndColumns.Length != 2 | numberLinesAndColumns[0] <1 | numberLinesAndColumns[1] < 1)
        {
            throw new ArgumentException("Введены неверные параметры массива");
        }

        else 
        {
            
            double [,] outArray = new double[numberLinesAndColumns[0], numberLinesAndColumns[1]];
            for(int i = 0; i < outArray.GetLength(0); i++)
            {
                for(int j = 0; j < outArray.GetLength(1); j++)
                {
                    outArray[i,j] = GenerationRandomDoubleFractional(numberMin, numberMax);
                }
            }
            return outArray;
        }
        
    }

    //Метод генерирующий рандомные числа (инт)
    public static int GenerationRandomInteger(int numberMin, int numberMax)
    {
        Random random = new Random();
        int outRandom = random.Next(numberMin, numberMax+1);
        return outRandom;
    }

    //Метод генерирующий рандомные числа (дабл)
    public static double GenerationRandomDouble(int numberMin, int numberMax)
    {
        Random random = new Random();
        double outRandom = (double)(random.Next(numberMin, numberMax+1));
        return outRandom;
    }

    //Метод генерирующий рандомные дробные числа (дабл)
    public static double GenerationRandomDoubleFractional(int numberMin, int numberMax)
    {
        Random random = new Random();
        double divider = 10;
        numberMax *=10;
        double outData = Convert.ToDouble(random.Next(numberMin, numberMax + 1)/divider);
        return outData;
    }
    


}