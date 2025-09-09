using System.Collections;
using System.Reflection.Emit;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here

            static int SignOf(int x)
            {
                if (x > 0) return 1;
                if (x < 0) return -1;
                return 0;
            }

            answer = SignOf(a) == SignOf(b);

            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here

            answer = d % 1.0 != 0;

            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here

            answer = b != 0 && a % b == 0;

            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here

            static double solve(double a, double b) => (Math.Abs(a) > Math.Abs(b)) ? a : b;

            answer = solve(solve(d, f), g);

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here

            double solve()
            {
                if (x <= -1) return 0;
                if (x > 0) return 1;
                return x + 1;
            }

            answer = solve();

            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here

            var square_side = Math.Sqrt(squareS);
            var circle_radius = Math.Sqrt(circleS / Math.PI);

            answer = 2.0 * circle_radius <= square_side;

            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here

            if (Math.Abs(d) < Math.Abs(f))
            {
                if (d > 0) answer = -1;
            }
            else
            {
                if (f > 0) answer = 1;
            }

            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here

            var total = a / 2 + b / 2 + c / 2;

            bool solve(int delta)
            {
                if ((total + delta) % 3 != 0) return false;

                var k = (total + delta) / 3;

                if (k < 1) return false;

                return Math.Min(Math.Min(a, b), c) >= k;
            }

            answer = solve(0) || solve(1);

            // end

            return answer;
        }
    }
}