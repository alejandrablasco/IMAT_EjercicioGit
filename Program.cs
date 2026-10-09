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

        static int Subtract(int x, int y)
        {
            return x - y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Resta: 2 - 2 = {Subtract(2, 2)}");
        }
    }
}