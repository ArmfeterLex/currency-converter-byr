using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите стоимость товара в белорусских рублях");
        int a = int.Parse(Console.ReadLine());
        double b = Math.Round((a * 28.8),2); double c = Math.Round((a * 0.2737), 2); double d = Math.Round((a*12.6), 2);
        Console.WriteLine("Стоимость товара в русских рублях {0:f2}; в евро {1:f2}; в гривнах {2:f2}", b, c, d);
        Console.ReadKey();
    }
}
