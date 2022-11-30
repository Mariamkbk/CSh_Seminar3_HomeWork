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
    int FirstNum = 1;
    int LastNum = 1;
    while (mult > (DigNum / 2))
    {
        if (FirstNum == LastNum)
        {
            FirstNum = (Convert.ToInt32(num / (Math.Pow(10, (mult))))) % 10;
            LastNum = (num % divider) % 10;
            mult--;
            LastMult++;
            divider = Convert.ToInt32(Math.Pow(10, LastMult));
        }
        else
        {
            Console.WriteLine($"Число {num} не является палиндромом");
        }
    }
    if (mult<=Dignum)
    {
       Console.WriteLine($"Число {num} является палиндромом"); 
    }
}
catch
{
    Console.WriteLine("Введены некорректные данные. Пожалуйста, вводите только числовое значение");
}