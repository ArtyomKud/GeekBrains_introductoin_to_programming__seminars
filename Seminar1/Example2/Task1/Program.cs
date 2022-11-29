Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
int square = number1*number1;
if(number2 == square)
{
    Console.WriteLine("Второе число является квадратом первого числа!");
}
else {
     Console.WriteLine("Второе число не является квадратом первого числа!");
}