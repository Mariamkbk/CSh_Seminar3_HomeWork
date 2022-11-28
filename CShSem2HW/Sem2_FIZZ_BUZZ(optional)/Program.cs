//Напишите программу, которая выводит на экран числа от 1 до 100. 
//При этом вместо чисел, кратных трем, программа должна выводить слово Fizz, 
//а вместо чисел, кратных пяти — слово Buzz. Если число кратно пятнадцати, 
//то программа должна выводить слово FizzBuzz. 
//Задача может показаться очевидной, но нужно получить наиболее простое и красивое решение.

string DoFizzBuzz(int x, int b, int c)
{
    for (x = 1; x <= 10; x++)
    {
        b = x % 3;
        c = x % 5;
        switch (b)
        {
            case 0: Console.Write("Fizz");
            default:;
        }
        switch (c)
        {
            case 0: Console.Write($"Buzz ");
            goto default;
            default: return (x);
        }
    }
}

DoFizzBuzz(x, b, c);