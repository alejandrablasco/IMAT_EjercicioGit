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

        static void Main(string[] args)
        {
            // ID 202403124 -> primer dígito 2, último dígito 4
            Console.WriteLine($"Multiplicación: 2 * 4 = {Multiply(2, 4)}");
        }
    }
}