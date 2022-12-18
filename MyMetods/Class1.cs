namespace MyMetods;
public static class Class1


{
    public static void PrintArray (int [] array1)
    {
        Console.WriteLine($"[{String.Join(" ,", array1)}]");
    }

    public static void PrintArray (double [] array1)
    {
        Console.WriteLine($"[{String.Join(" ,", array1)}]");
    }

    public static void PrintArray (String [] array1)
    {
        Console.WriteLine($"[{String.Join(" ,", array1)}]");
    }



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


}