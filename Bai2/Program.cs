namespace Bai2
{
    internal class Program
    {
        static int ToThePowerOf(int a, int n)
        {
            if (n == 0)
                return 1;
            else if (n % 2 == 0)
                return ToThePowerOf(a, n / 2) * ToThePowerOf(a, n / 2);
            else
                return a * ToThePowerOf(a, (n - 1) / 2) * ToThePowerOf(a, (n - 1) / 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ToThePowerOf(3, 3));
        }
    }
}