namespace Matrix_03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row, coulmn, number;
            Console.Write("Enter the row length: ");
            int.TryParse(Console.ReadLine(), out row);
            Console.Write("Enter the column length: ");
            int.TryParse(Console.ReadLine(), out coulmn);
            int[,] matrix = new int[row, coulmn];
            Random random = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coulmn; j++)
                {
                    matrix[i, j] = random.Next(3, 15);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.Write("Enter the your number:");
            int.TryParse(Console.ReadLine(), out number);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coulmn; j++)
                {
                    if (matrix[i, j] == number)
                    {
                        matrix[i, j - 1] = 0; matrix[i, j + 1] = 0;
                    }
                }

            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coulmn; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}