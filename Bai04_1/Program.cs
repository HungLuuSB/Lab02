namespace Bai04_1
{
    internal class Program
    {
        static int Calc(int k)
        {
            if (k == 0 || k == 1)
                return 1;
            else if (k == 2)
                return 2;
            else
                return (Calc(k - 1) + Calc(k - 2) + Calc(k - 3));
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Calc(5));
        }
    }
}