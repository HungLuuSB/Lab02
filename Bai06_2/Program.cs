namespace Bai06_2
{
    internal class Program
    {
        static int SumOnCrossing(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += (matrix[i,i]%2==0)?matrix[i,i]:0;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine(SumOnCrossing(matrix));
        }
    }
}