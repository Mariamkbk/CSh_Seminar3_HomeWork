try
{
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    int DigNum = Convert.ToInt32(Math.Round((Math.Log10(num)), MidpointRounding.ToZero));
    int mult = DigNum;
    int LastMult = 1;
    int divider = 1;
    int FirstNum = (Convert.ToInt32(Math.Round((num / (Math.Pow(10, (mult)))), MidpointRounding.ToZero)));
    int LastNum = (num / divider) % 10;
    while (mult > (DigNum / 2) && LastNum==FirstNum)
    {
        mult--;
        FirstNum = (Convert.ToInt32(Math.Round((num / (Math.Pow(10, (mult)))), MidpointRounding.ToZero))) % 10;
        divider = Convert.ToInt32(Math.Pow(10, LastMult));
        LastNum = (num / divider) % 10;
        LastMult++;
        
    }
    if (mult <= DigNum / 2)
    {
        Console.WriteLine($"Число {num} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {num} не является палиндромом");
    }
}
catch
{
    Console.WriteLine("Введены некорректные данные. Пожалуйста, вводите только числовое значение");
}
