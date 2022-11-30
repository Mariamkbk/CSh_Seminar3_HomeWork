// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, 
// является ли оно палиндромом. Через строку нельзя решать само собой.

try
{
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    int DigNum = Convert.ToInt32(Math.Log10(num));
    int mult = DigNum;
    int LastMult = 1;
    int divider = 1;
    for (int LastNum = 1, FirstNum = 1; mult > (DigNum / 2); mult--, LastMult++)
    {
        if (LastNum == FirstNum)
        {
            FirstNum = (Convert.ToInt32(num / (Math.Pow(10, (mult))))) % 10;
            LastNum = (num % divider) % 10;
            divider = Convert.ToInt32(Math.Pow(10, LastMult));

        }
    }
    if (LastNum > FirstNum && LastNum < FirstNum)
        {
            Console.WriteLine($"Число {num} не является палиндромом");
        }
        else
        {
            Console.WriteLine($"Число {num} является палиндромом");
        }
}
catch
{
    Console.WriteLine("Введены некорректные данные. Пожалуйста, вводите только числовое значение");
}