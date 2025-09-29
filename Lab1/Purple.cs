namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            answer = (a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c < 0);

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            answer = (b != 0 && a % b == 0) || (a != 0 && b % a == 0);

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            long A = a, B = b;
            answer = (A * A == B) || (B * B == A) || (A * A * A == B) || (B * B * B == A);

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            answer = f * f - 4 * d * g;

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            if (x <= -1) answer = 1;
            else if (x <= 1) answer = -x;
            else answer = -1;

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            double a = System.Math.Sqrt(squareS);
            double r = System.Math.Sqrt(circleS / System.Math.PI);

            answer = r + 1e-12 >= a * System.Math.Sqrt(2) / 2;

            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            if (s)
            {
                if (t) answer = 6;
                else
                {
                    if (f) answer = 10;
                    else answer = 2;
                }
            }
            else
            {
                if (t) answer = 3;
                else
                {
                    if (f) answer = 5;
                    else answer = 1;
                }
            }


            return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {


            bool answer = false;
            const int bank = 10000;

            bool isLeap = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            if (isLeap) return false;

            int aurors = (int)System.Math.Ceiling(pupils / 7.0);

            int cost = aurors * salary + pupils * 5;

            answer = cost <= bank;

            return answer;
        }
    }
}