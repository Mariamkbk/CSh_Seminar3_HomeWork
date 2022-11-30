// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.

try
{
    Console.WriteLine("Введите числовое значение мерности пространства");
    int N = Convert.ToInt32(Console.ReadLine());
    double[] CoordA = new double[N];
    double[] CoordB = new double[N];
    int i;
    double sum = 0;
    for (i = 0; i < N; i++)
    {
        Console.WriteLine($"Введите {i + 1} координату точки А");
        CoordA[i] = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Введите {i + 1} координату точки B");
        CoordB[i] = Convert.ToDouble(Console.ReadLine());
    }
    for (i = 0; i < N; i++)
    {
        sum = (Math.Pow(CoordB[i] - CoordA[i], 2)) + sum;
    }
    Console.WriteLine($"Расстояние между точками А и В равно {Math.Sqrt(sum)}");
}
catch
{
    Console.WriteLine("Введены некорректные данные");
}