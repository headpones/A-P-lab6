class Program
{
    static int[,] FillMatrix(int rows, int cols)
    {
        Random random = new Random();
        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(0, 101);
            }
        }
        return matrix;
    }
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    static void SwapColumns(int[,] matrix, int col1, int col2)
    {
        int rows = matrix.GetLength(0);
        for (int i = 0; i < rows; i++)
        {
            int temp = matrix[i, col1];
            matrix[i, col1] = matrix[i, col2];
            matrix[i, col2] = temp;
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Введіть кількість рядків (M): ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введіть кількість стовпців (N): ");
        int cols = int.Parse(Console.ReadLine());
        if (rows <= 0 || cols <= 0)
        {
            Console.WriteLine("Розміри матриці мають бути більшими за 0!");
            return;
        }
        int[,] matrix = FillMatrix(rows, cols);
        Console.WriteLine("\nЗгенерована матриця:");
        PrintMatrix(matrix);
        Console.Write("\nВведіть номер першого стовпця для перестановки (від 0): ");
        int col1 = int.Parse(Console.ReadLine());
        Console.Write("Введіть номер другого стовпця для перестановки (від 0): ");
        int col2 = int.Parse(Console.ReadLine());
        if (col1 < 0 || col1 >= cols || col2 < 0 || col2 >= cols)
        {
            Console.WriteLine("Номери стовпців мають бути в межах від 0 до N-1!");
            return;
        }
        SwapColumns(matrix, col1, col2);
        Console.WriteLine("\nМатриця після перестановки стовпців:");
        PrintMatrix(matrix);
    }
}
