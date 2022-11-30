Console.Write ("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write ("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
int number_max = 0;
if (number1 == number2)
{
    Console.WriteLine ("Числа равны");
}
if (number1 > number2)
{
    number_max = number1;
}
if (number1 < number2)
{
    number_max = number2;
}
Console.WriteLine ("Максимальное число " + number_max);
