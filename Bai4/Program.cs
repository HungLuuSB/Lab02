namespace Bai4
{
    internal class Program
    {
        /*Entry n = 20
         * (1) = (20 % 2 + 10 * DtB(10)) = 0 + 10 * 1010 = 10100
         * (2) = (10 % 2 + 10 * DtB(5)) = 0 + 10 * 101 = 1010
         * (3) = (5 % 2 + 10 * DtB(2)) = 1 + 10 * 10 = 101
         * (4) = (2 % 2 + 10 * DtB(1)) = 0 + 10 * 1 = 10
         * (5) = (1 % 2 + 10 * DtB(0)) = 1 + 10 * 0 = 1
         * (6) = 0
        */
        static int DecToBin(int n)
        {
            if (n == 0)
                return 0;
            else
                return (n % 2 + 10 * DecToBin(n/2));
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DecToBin(20));
        }
    }
}