namespace Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row, coulmn,max=0,min=16;
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
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coulmn; j++)
                {
                    if (matrix[i,j]>max)
                    {
                        max = matrix[i,j];
                    }
                    if (matrix[i,j]<min)
                    {
                        min = matrix[i,j];  

                    }
                }
            }
            Console.WriteLine($"Max={max}");
            Console.WriteLine($"Min={min}");
        }
    }
}