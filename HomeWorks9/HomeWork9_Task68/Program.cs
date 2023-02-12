/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int m = 3;
int n = 2;

int result = FunctionAkkermana(m, n);
Console.WriteLine(result);


int FunctionAkkermana(int m1, int n1)
{
    if( m1 == 0)
    {
        return n1+1;
    }
    if(m1 > 0 & n1 == 0)
    {
        return FunctionAkkermana(m1-1, 1);
    }
    if(m1 > 0 & n1 > 0)
    {
        return FunctionAkkermana(m1-1, FunctionAkkermana(m1, n1-1));
    }
    return n1+1;

}