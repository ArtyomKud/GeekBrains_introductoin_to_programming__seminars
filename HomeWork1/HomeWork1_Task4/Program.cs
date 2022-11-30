Console.Write ("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write ("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write ("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());

int number_max = number1;


if (number2 > number_max)
{
    number_max = number2;
}
if (number3 > number_max)
{
    number_max = number3;
}
Console.WriteLine ("Максимальное число " + number_max);