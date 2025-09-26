using System.Diagnostics;

namespace Lab1
{
    public class Program
    {
        public static void Main()
        {
            White white = new White();
            Console.WriteLine(white.Task1(1.2));
            Console.WriteLine(white.Task2(2));
            Console.WriteLine(white.Task3(2, 1));
        }
    }
}   