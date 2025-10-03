using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if (a != 0 && b != 0 && a * b > 0)
                answer = true;
            // end
            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            double c = Math.Floor(d);
            if (d > c || d < c)
                answer = true;

            // end
            Console.WriteLine(answer);
            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0 && a % b == 0)
                answer = true;
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double d2;
            double f2;
            double g2;
            Console.WriteLine($"{d}, {f}, {g}");
            d2 = Math.Abs(d);
            f2 = Math.Abs(f);
            g2 = Math.Abs(g);
            if (d2 > f2 && d2 > g2)
                answer = d;
            else if (f2 > d2 && f2 > g2)
                answer = f;
            else if (g2 > d2 && g2 > f2)
                answer = g;
                // end

                return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1)
                answer = 0;
            else if (x > -1 && x <= 0)
                answer = x + 1;
            else
                answer = 1;
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double k = Math.Sqrt(squareS);
            double c = Math.Sqrt(circleS / Math.PI);
            if (c <= (k / 2))
                answer = true;
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (Math.Abs(d) < Math.Abs(f))
                if (d > 0)
                    answer = -1;
                else
                {
                    return answer;
                }
            else if (f > 0)
                    answer = 1;
              
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            double a2 = a / 2;
            double b2 = b / 2;
            double c2 = c / 2;
            a2 = Math.Floor(a2);
            b2 = Math.Floor(b2);
            c2 = Math.Floor(c2);
            double sum = a2 + b2 + c2;
            if (sum % 3 == 0 && sum >= 3)
                answer = true;
            if (sum % 3 == 2 && sum >= 2)
                answer = true;
            // end
            Console.WriteLine(answer);
            return answer;
        }
    }
}
