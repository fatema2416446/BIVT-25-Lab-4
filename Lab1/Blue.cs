using System;
namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            int signa, signb;
            signa = 0;
            signb = 0;
            if (Math.Abs(a) != a)
            {
                signa = 1;
            }
            else if (a != 0)
            {
                signa = 2;
            }
            if (Math.Abs(b) != b)
            {
                signb = 1;
            }
            else if (b != 0)
            {
                signb = 2;
            }
            if (signa == signb)
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            int fulld;
            double dd;
            fulld = (int)d;
            dd = fulld;
            if (dd != Math.Round(d, 4))
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0)
            {
                if (a % b == 0)
                {
                    answer = true;
                }
            }
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            if (Math.Abs(d) > Math.Abs(f))
            {
                if (Math.Abs(d) > Math.Abs(g))
                {
                    answer = d;
                }
                else if (Math.Abs(g) > Math.Abs(f))
                {
                    answer = g;
                }
                else
                {
                    answer = f;
                }
            }
            else if (Math.Abs(f) > Math.Abs(g))
            {
                answer = f;
            }
            else
            {
                answer = g;
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1)
            {
                answer = 0;
            }
            else if (x > 0)
            {
                answer = 1;
            }
            else
            {
                answer = x + 1;
            }
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double PI = 3.1415926535897931;
            double dio;
            dio = (circleS / PI) * 4;
            if (dio <= squareS)
            {
                answer = true;
            }
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
            }
            else
            {
                if (f > 0)
                {
                    answer = 1;
                }
            }
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int zoloto = (a / 2) + (b / 2) + (c / 2);
            if ((zoloto % 3 == 0) && (zoloto != 0))
            {
                if (((zoloto / 3) <= c) && ((zoloto / 3) <= b) && ((zoloto / 3) <= a))
                {
                    answer = true;
                }
            }
            else if (zoloto % 3 == 2)
            {
                if ((((zoloto + 1) / 3) <= c) && (((zoloto + 1) / 3) <= b) && (((zoloto + 1) / 3) <= a))
                {
                    answer = true;
                }
            }
            // end

            return answer;
        }
    }
}