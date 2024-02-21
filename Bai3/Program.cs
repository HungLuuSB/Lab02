namespace Bai3
{
    internal class Program
    {
        static int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return GCD(b, a % b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GCD(15, 9));
        }
    }
}