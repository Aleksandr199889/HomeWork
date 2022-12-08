Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
if(N % 23 == 0)
{
    if(N % 7 == 0)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Нет");
}