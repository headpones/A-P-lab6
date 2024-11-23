class Program
{
    static bool IsPowerOfTwo(int n)
    {
        if (n == 1) return true;
        if (n % 2 != 0 || n == 0) return false;
        return IsPowerOfTwo(n / 2);
    }

    static void Main(string[] args)
    {
        Console.Write("Введіть натуральне число N: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Число має бути натуральним!");
            return;
        }

        if (IsPowerOfTwo(n))
            Console.WriteLine($"Число {n} є точною степінню двійки.");
        else
            Console.WriteLine($"Число {n} НЕ є точною степінню двійки.");
    }
}