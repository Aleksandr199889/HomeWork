Console.WriteLine("Введите трёхзначное число");
int N = Convert.ToInt32(Console.ReadLine());
int F = N / 10;
int S = F % 10;
Console.WriteLine("Вторая цифра" + S);