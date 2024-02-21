namespace Bai05_2
{
    internal class Program
    {
        static int checkForSmallestPositive(int[] matrix)
        {

            List<int> list = new List<int>();
            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i] > 0)
                   list.Add(matrix[i]);
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
            int n = Convert.ToInt32(Console.ReadLine());
            int[] matrix = new int[n];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = Convert.ToInt32(Console.ReadLine());
            }
            int result = checkForSmallestPositive(matrix);
            Console.WriteLine((result == -1) ? "Could not find any smallest positive number" : ("Found: ", result));
        }
    }
}