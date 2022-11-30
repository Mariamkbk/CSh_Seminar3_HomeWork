// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, 
// является ли оно палиндромом. Через строку нельзя решать само собой.

int mult = DigNum;

try
{
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    int DigNum = Convert.ToInt32(Math.Log10(num));
    int FirstNum = (Convert.ToInt32(num / (Math.Pow(10, (mult))))) % 10;
    int LastNum = num % 10;
    while (mult > (DigNum / 2))
        if (FirstNum == LastNum)
        {
            mult--;
            FirstNum = (Convert.ToInt32(num / (Math.Pow(10, (mult))))) % 10;
            LastNum = num % 10 * count;
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