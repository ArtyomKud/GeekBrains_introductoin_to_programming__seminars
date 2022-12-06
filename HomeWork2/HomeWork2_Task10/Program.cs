int number_user = 0;
while (number_user < 100 || number_user >999)
{
 Console.Write("Введите трехзначное число ");
 number_user = int.Parse(Console.ReadLine());
 if(number_user < 100 && number_user > 999)
 {
    Console.WriteLine ("Вы ввели не трехзначное число");
 }
}
int one_number = number_user/100;
int three_number = number_user%10;
int result = (number_user - (one_number*100+three_number))/10;
Console.WriteLine($"Результат = {result}");