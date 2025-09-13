using System.ComponentModel;
using System.Numerics;

namespace Lab1
{
    public class Program
    {
        public static void Main()
        {
            /**/
            Blue blue = new Blue();
            Console.WriteLine("Blue");
            Console.WriteLine("\n#1");
            Console.WriteLine(blue.Task1(3, 0));
            Console.WriteLine(blue.Task1(0, -2));
            Console.WriteLine(blue.Task1(0, 0));
            Console.WriteLine(blue.Task1(3, 6));
            Console.WriteLine(blue.Task1(-64, -120));
            Console.WriteLine(blue.Task1(-2, 6));
            Console.WriteLine(blue.Task1(2, -3));
            Console.WriteLine("\n#2");
            Console.WriteLine(blue.Task2(4));
            Console.WriteLine(blue.Task2(-2));
            Console.WriteLine(blue.Task2(1.00000005));
            Console.WriteLine(blue.Task2(-0.219));
            Console.WriteLine(blue.Task2(10201.0001));
            Console.WriteLine("\n#3");
            Console.WriteLine(blue.Task3(19, 721));
            Console.WriteLine(blue.Task3(39, 4));
            Console.WriteLine(blue.Task3(29, 0));
            Console.WriteLine(blue.Task3(0, 0));
            Console.WriteLine(blue.Task3(72, 12));
            Console.WriteLine(blue.Task3(72, -6));
            Console.WriteLine(blue.Task3(3, 1));
            Console.WriteLine(blue.Task3(0, 12));
            Console.WriteLine("\n#4");
            Console.WriteLine(blue.Task4(4.1, -233, -32.124));
            Console.WriteLine(blue.Task4(1, -23, 8));
            Console.WriteLine(blue.Task4(39, -16, 24));
            Console.WriteLine(blue.Task4(29.0, -23, 91));
            Console.WriteLine(blue.Task4(1, 4.0, -3));
            Console.WriteLine("\n#5");
            Console.WriteLine(blue.Task5(-4));
            Console.WriteLine(blue.Task5(-1.000001));
            Console.WriteLine(blue.Task5(-1));
            Console.WriteLine(blue.Task5(-0.999999));
            Console.WriteLine(blue.Task5(-0.7));
            Console.WriteLine(blue.Task5(-0.4));
            Console.WriteLine(blue.Task5(-0.00001));
            Console.WriteLine(blue.Task5(0));
            Console.WriteLine(blue.Task5(0.00001));
            Console.WriteLine(blue.Task5(20239));
            Console.WriteLine("\n#6");
            Console.WriteLine(blue.Task6(5 * 5 * Math.PI + 0.1, 10 * 10));
            Console.WriteLine(blue.Task6(5 * 5 * Math.PI, 10 * 10));
            Console.WriteLine(blue.Task6(5 * 5 * Math.PI - 0.1, 10 * 10));
            Console.WriteLine("\n#7");
            Console.WriteLine(blue.Task7(0.1, 0.2));
            Console.WriteLine(blue.Task7(0.1, -0.2));
            Console.WriteLine(blue.Task7(-0.1, 0.2));
            Console.WriteLine(blue.Task7(0, -0.2));
            Console.WriteLine(blue.Task7(0.2, 0.1));
            Console.WriteLine(blue.Task7(0.2, -0.1));
            Console.WriteLine(blue.Task7(-0.2, 0.1));
            Console.WriteLine(blue.Task7(-0.2, 0));
            Console.WriteLine(blue.Task7(5, 5));
            Console.WriteLine(blue.Task7(-5, 5));
            Console.WriteLine(blue.Task7(5, -5));
            Console.WriteLine(blue.Task7(-5, -5));
            Console.WriteLine(blue.Task7(0, 0));
            Console.WriteLine("\n#8");
            Console.WriteLine(blue.Task8(4, 6, 9));
            Console.WriteLine(blue.Task8(0, 0, 4));
            Console.WriteLine(blue.Task8(2, 3, 4));
            Console.WriteLine(blue.Task8(0, 1, 1));
            Console.WriteLine(blue.Task8(0, 0, 1));
            Console.WriteLine(blue.Task8(0, 0, 0));

            White white = new White();
            Console.WriteLine("\nWhite");
            Console.WriteLine("\n#4");
            Console.WriteLine(white.Task4(1.5, 1.5));
            Console.WriteLine(white.Task4(1.5, -1.5));
            Console.WriteLine(white.Task4(-1.5, 1.5));
            Console.WriteLine(white.Task4(-1.5, -1.5));
            /*
            Console.WriteLine("\n#6");
            var input = new double[,] {
                { 0, 1.5, 1, 1, -1, 3, -1, -2.3, 2, 1 },
                { 0, 2.3, -1, -1, 1, 0.01, 1.23, -3.2, 1, 0 },
                { 0, 1, 1, 0.5, 1.5, 3, 2, 2.5, 1, 1 }
            };
            var answer = new bool[] { true, false, false, false, false, true, false, false, false, true };

            for (int i = 0; i < 10; ++i)
            {
                bool my_ans = white.Task6(input[0, i], input[1, i], input[2, i]);
                if (my_ans == answer[i])
                {
                    Console.WriteLine("+");
                }
                else
                {
                    white.Task6(input[0, i], input[1, i], input[2, i]);
                    Console.WriteLine("-");
                }
            }
            */

            Green green = new Green();
            Console.WriteLine("\nGreen");
            Console.WriteLine("\n#6");
            Console.WriteLine(green.Task6(1, 3));
            Console.WriteLine(green.Task6(0.5, 0.5));
            Console.WriteLine(green.Task6(0, 0.5));
        }
    }
}