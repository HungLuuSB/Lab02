namespace Bai5
{
    internal class Program
    {
        static int NumberOfRabbits(int month)
        {
            if (month == 1 || month == 2)
                return 1;
            else
                return NumberOfRabbits(month - 1) + NumberOfRabbits(month - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfRabbits(4));
        }
    }
}