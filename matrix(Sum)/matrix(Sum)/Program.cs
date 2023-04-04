namespace matrix_Sum_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*mxn o’lchamli massiv va k butun son berilgan. 
             * Massivning k ustuni elementlarini yig’indisi 
             * va ko’paytmasini chiqaruvchi dastur tuzing.*/
            int row, coulmn, sum = 0, mult = 1, k;
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
            Console.Write("Select the desired column:");
            int.TryParse(Console.ReadLine(), out k);
           
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coulmn; j++)
                {
                    if (j == k)
                    {
                        sum += matrix[i, j];
                        mult *= matrix[i, j];
                    }
                }

            }
            Console.WriteLine("Sum="+sum);
            Console.WriteLine("mult="+mult);


                
        }
    }
}

    