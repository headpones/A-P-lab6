class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Введіть значення k: ");
            double k = double.Parse(Console.ReadLine());
            Console.Write("Введіть значення x: ");
            double x = double.Parse(Console.ReadLine());
            double c = Math.Atan(x);
            double a = c + Math.Pow(k, 2);
            double y = Math.Pow(Math.Sin(a), 3) + Math.Pow(Math.Cos(x), 2);
            Console.WriteLine($"Обчислене значення y: {y:F4}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}