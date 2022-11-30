// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//Напиште программу которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.

try
{
    Console.WriteLine("Введите число");
    int N = Convert.ToInt32(Console.ReadLine());
    int a;
    if (N <= 0)
    {
        for (a = 1; a >= N; a--)
        {
            Console.Write($"{Math.Pow(a, 3)} ");
        }
    }
    else
    {
        for (a = 1; a <= N; a++)
        {
            Console.Write($"{Math.Pow(a, 3)} ");
        }
    }
}
catch
{
    Console.WriteLine("Введены некорректные данные");
}