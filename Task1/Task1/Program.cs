class Program
{
    static int Power(int a, int x)
    {
        int result = 1;
        for (int i = 0; i < x; i++)
        {
            result *= a;
        }
        return result;
    }
    static void Main(string[] args)
    {
        Console.Write("Введіть число a (натуральне): ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введіть число x (натуральне): ");
        int x = int.Parse(Console.ReadLine());
        if (a <= 0 || x <= 0)
        {
            Console.WriteLine("Числа мають бути натуральними!");
            return;
        }
        int resultA = Power(a, x);
        int resultX = Power(x, a);
        Console.WriteLine($"{a} в степені {x} дорівнює {resultA}");
        Console.WriteLine($"{x} в степені {a} дорівнює {resultX}");
    }
}