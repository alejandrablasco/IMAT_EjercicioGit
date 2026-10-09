namespace IMAT_GitTest
{
    internal class Program
    {
        static int Add(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            // ID 202405782 -> primer dígito 2, último dígito 2
            Console.WriteLine($"Suma: 2 + 2 = {Add(2, 2)}");
        }
    }
}