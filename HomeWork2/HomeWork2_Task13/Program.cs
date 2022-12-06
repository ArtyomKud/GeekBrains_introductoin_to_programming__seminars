int number_user = 0;
int result = 0;
while (number_user < 100)
{
 Console.Write("Введите число от 100: ");
 number_user = int.Parse(Console.ReadLine());
 if(number_user < 100)
 {
    Console.WriteLine ("Вы ввели число менее 100 ");

 }
}
int div = 10;
while ((number_user / div) > 999)
{
    div = div*10;
}
if (number_user < 1000)
{
  result = number_user%10;  
}
else 
{
 number_user = number_user/div;
 result = number_user%10;
}
Console.WriteLine(result);