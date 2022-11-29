// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

try
{
    Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 9999 && num < 100000 || num < -9999 && num > -100000)
{
    int FirstNum = num / 10000;
    int LastNum = num % 10;
    if (FirstNum == LastNum)
    {
        FirstNum = (num / 1000) % 10;
        LastNum = (num / 10) % 10;
        if (FirstNum == LastNum)
        {
            Console.WriteLine($"Число {num} является палиндромом");
        }
        else
        {
            Console.WriteLine($"Число {num} не является палиндромом");
        }
    }
    else
    {
        Console.WriteLine($"Число {num} не является палиндромом");
    }
}
else
{
    Console.WriteLine($"Число {num} не является пятизначным");
}
}
catch
{
    Console.WriteLine($"Некорректные данные. Убедитесь, что вводите числовое значение.");
}

