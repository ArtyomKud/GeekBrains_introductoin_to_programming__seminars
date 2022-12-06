int number_day = 10;
while (number_day < 1 | number_day > 7)
{
Console.Write("Введите порядковый номер дня недели: ");
number_day = int.Parse(Console.ReadLine());
Console.WriteLine("Введено некорректное число!!!");
}
if (number_day >= 6)
{
    Console.WriteLine("Введенный день недели выходной");
}
else 
{
    Console.WriteLine("Введенный день не выходной");
}