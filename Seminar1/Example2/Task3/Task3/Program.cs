Console.Write("Введите номер дня недели: ");
int numberDay = int.Parse(Console.ReadLine());
if (numberDay < 0 | numberDay > 7)
{
Console.WriteLine("Введите корректное число");
}
if (numberDay == 1)
{
Console.WriteLine("Понедельник");
}
if (numberDay == 2)
{
Console.WriteLine("Вторник");
}
if (numberDay == 3)
{
Console.WriteLine("Среда");
}
if (numberDay == 4)
{
Console.WriteLine("Четверг");
}
if (numberDay == 5)
{
Console.WriteLine("Пятница");
}
if (numberDay == 6)
{
Console.WriteLine("Суббота");
}
if (numberDay == 7)
{
Console.WriteLine("Воскресенье");
}