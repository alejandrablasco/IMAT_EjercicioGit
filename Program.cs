namespace IMAT_GitTest
{
    internal class Program
    {
        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Divide(int x, int y)
        {
            return x / y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"División: 2 / 4 = {Divide(2, 4)}");
        }
    }
}