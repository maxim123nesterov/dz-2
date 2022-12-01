//Нахождение 3 цифры трехзначного числа.
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 99 && a < 1000)
{
    int num = a % 10;
    Console.Write($"третья цифра {num}");
}
if (a < 100)
{
    Console.WriteLine("третьей цифры нет");
}