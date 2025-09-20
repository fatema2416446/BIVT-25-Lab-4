using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if (a == b) answer = true;
            if (a > 0 && b > 0) answer = true;
            if (a < 0 && b < 0) answer = true;
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            int diddy = (int)d;
            double pdiddy = (double)diddy;
            if (d != pdiddy) answer = true;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0) if (a % b == 0) answer = true;
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double absD = Math.Abs(d);
            double absF = Math.Abs(f);
            double absG = Math.Abs(g);
            if (absD > absF && absD > absG) answer = d;
            if (absF > absD && absF > absG) answer = f;
            if (absG > absD && absG > absF) answer = g;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1) answer = 0;
            if (-1 < x && x <= 0) answer = x + 1;
            if (x > 0) answer = 1;
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double radius = Math.Sqrt(circleS / Math.PI);
            if (radius * 2 <= Math.Sqrt(squareS)) answer = true;
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (Math.Abs(d) < Math.Abs(f))
            {
                if (d > 0)
                {
                    answer = -1;
                }
                else answer = 0;
            }
            else if (f > 0)
            {
                answer = 1;
            }
            else answer = 0;
                // end

                return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int old = a / 2;
            int mid = b / 2;
            int young = c / 2;
            int sum = old + mid + young;
            if (a > 0 && b > 0 && c > 0)
            {
                if (sum % 3 == 0) answer = true;
                if ((sum + 1) % 3 == 0) answer = true;
            }
            // end

            return answer;
        }
    }
}