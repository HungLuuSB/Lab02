namespace Bai06_1
{
    internal class Program
    {
        static int checkForSmallestPositive(int[,] matrix)
        {

            List<int> list = new List<int>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                        list.Add(matrix[i, j]);
                }
            }
            if (list.Count > 0)
            {
                int min = list[0];
                foreach (var num in list)
                {
                    if (num < min)
                        min = num;
                }
                return min;
            }
            else
            {
                return -1;
            }
            
        }
        static void Main(string[] args)
        {
            int rows = Convert.ToInt32(Console.ReadLine());
            int cols = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int result = checkForSmallestPositive(matrix);
            Console.WriteLine((result==-1)?"Could not find any smallest positive number":("Found: ",result));
        }
    }
}