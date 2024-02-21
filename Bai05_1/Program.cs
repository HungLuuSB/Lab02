namespace Bai05_1
{
    internal class Program
    {
        static int MangDoiXung(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != a[a.Length - 1 -i])
                    return 0;
            }
            return 1;
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 5, 1 };

            Console.WriteLine(MangDoiXung(a));
        }
    }
}