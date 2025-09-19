using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a > 0 && b > 0) || (a < 0 && b < 0)) answer = true;
            
                // end

                return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            if (d != Math.Floor(d)) answer = true;

            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0)
            {
                answer = a % b == 0;

            }

            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            if (Math.Abs(d) > Math.Abs(f) && Math.Abs(d) > Math.Abs(g))
            {
                answer = d;
            }
            else if (Math.Abs(f) > Math.Abs(d) && Math.Abs(f) > Math.Abs(g))
            {
                answer = f;
            }
            else answer = g;

                // end

                return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if ( x <= -1) answer = 0;
            if (-1 < x && x <= 0) answer = x + 1;
            if (x > 0) answer = 1;

            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            answer = (Math.Sqrt(squareS) >= 2 * Math.Sqrt(circleS / Math.PI));
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
            else if (f > 0)
            {
                answer = 1;
            }
                // end

                return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            int monets = a / 2 + b / 2 + c / 2;

            if (monets % 3 == 0)
            {
                int person = monets / 3;

                if (a >= person && b >= person && b >= person && person >= 1)
                {
                    answer = true;
                }
            }
            else
            {
                if ((monets + 1) % 3 == 0)
                {
                    int person = (monets + 1) / 3;

                    if (a >= person && b >= person && b >= person && person >= 1)
                    {
                        answer = true;
                    }
                }
            }

            // end

            return answer;
        }
    }
}