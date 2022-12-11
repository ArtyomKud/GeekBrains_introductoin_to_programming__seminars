
/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом. Задание должно быть выполнено в методе. 
В методе не должно быть вывода в консоль. Не использовать String!
14212 -> нет
12821 -> да
23432 -> да */

int number = InputData();
String result = CheckForPalindrome(number);
Console.WriteLine(result);


int InputData()
{
    bool stopCycle = false;
    int inputNumber = -1;

    while (!stopCycle)
    {
        Console.Write("Введите целое положительное число: ");
        bool isParse = int.TryParse(Console.ReadLine(), out int inputNumber2);
        if(isParse && inputNumber2 >0)
        {
            stopCycle = true;
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели некорректное число");
            
        }
        inputNumber = inputNumber2;
    }
    return inputNumber;
    
}

String CheckForPalindrome (int numberToCheck)
{
    
    if(numberToCheck<10)
    {
        return "Число является палиндромом!";
    }

    double temp = numberToCheck;
    int dev = 1;
    int count = 1;

    while(temp > 9)
    {
        temp = temp/10;
        dev = dev*10;
        count++;
    }


    int[] arrayNumberToCheck = new int [count];

    for(int i = 0; i < arrayNumberToCheck.Length; i++)
    {
        arrayNumberToCheck[i] = numberToCheck/dev;
        numberToCheck = numberToCheck-arrayNumberToCheck[i]*dev;

        dev = dev/10;
    }
    int[] tempArray = new int[arrayNumberToCheck.Length];

    for(int i = 0, j = arrayNumberToCheck.Length-1; i < arrayNumberToCheck.Length; i++, j--)
    {
        tempArray[j]=arrayNumberToCheck[i];
    }

    String status = "Программа не работает!!!";

   

    for(int i = 0; i <arrayNumberToCheck.Length; i++)
    {
        if(arrayNumberToCheck[i] != tempArray[i])
        {
            status = "Число не является политдромом!";
            return status;
            break;
        }
        else 
        {
            status = "Число является полиндромом!!!";
        }
        
    }

 
    
    
    
    return status;


}

