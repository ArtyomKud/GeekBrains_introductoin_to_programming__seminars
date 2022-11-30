int number = 0;
while (number <= 1)
{
   Console.Write("Введите число: ");
   number = int.Parse(Console.ReadLine());
   if (number <= 1)
   {
    Console.WriteLine ("Введите число больше 1");
   } 
}

for (int i = 2; i <= number; i++)
{
    if (i%2 == 0)
    {
        Console.Write(i + " ");
    }
}
