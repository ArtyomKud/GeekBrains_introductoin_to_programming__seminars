/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними 
в 3D пространстве. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

double [] coordinatesOfTwoPoints = InputData();
double distanceBeetwenTwoPoints = FindingDistanceBetweenTwoPoints3D(coordinatesOfTwoPoints);
Console.WriteLine($"Расстояние между двумя точками = {distanceBeetwenTwoPoints}");


double [] InputData()
{
    bool stopCycle = false;    
    String [] coordinateName = {"x", "y", "z"};
    double [] coordinate = new double[6];
    int count = 0;


    for(int i = 1; i < 3; i++)
    {
        for(int j = 0; j < 3; j++)
        {
            stopCycle = false;
             while (!stopCycle)
                {
                    Console.Write($"Введите координату {coordinateName[j]} {i}й точки: ");
                    bool isParse = int.TryParse(Console.ReadLine(), out int inputNumber);
                    if(isParse)
                    {
                        stopCycle = true;
                        coordinate[count] = inputNumber;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели некорректное число");
            
                    }
                 
                }

        }
    }
    return coordinate;

   
    
    
}

void printArray (double [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ,");

    }
}

double FindingDistanceBetweenTwoPoints3D (double [] coordinates)
{
    double ax = coordinates[0];
    double ay = coordinates[1];
    double az = coordinates[2];
    double bx = coordinates[3];
    double by = coordinates[4];
    double bz = coordinates[5];
    double distance = Math.Sqrt((bx-ax)*(bx-ax)+(by-ay)*(by-ay)+(bz-az)*(bz-az));
    return distance;
}