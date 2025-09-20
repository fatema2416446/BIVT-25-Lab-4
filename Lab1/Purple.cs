using System.Runtime.InteropServices.Marshalling;

namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            // code here
            if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c < 0)) answer = true;
            // end

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            // code here
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (b != 0 && a % b == 0) answer = true;
            if (a != 0 && b % a == 0) answer = true;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a * a == b || a * a * a == b) || (b * b == a || b * b * b == a)) answer = true;


            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            answer = f * f - 4 * d * g;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1) answer = 1;
            if (x > -1 && x <= 1) answer = -x;
            if (x > 1) answer = -1;
            // end

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            // code here
            double Circle1 = Math.Sqrt(circleS / 3.14) * 2;
            double Square1 = Math.Sqrt(squareS) * Math.Sqrt(2);
            if (Square1 < Circle1) answer = true;
            // end

            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            // code here
            if (s == true)
            {
                if (t == true)
                {
                    answer = 6;
                }
                else 
                {
                    if(f == true)
                    {
                        answer = 10;
                    }
                    else
                    {
                        answer = 2;
                    }
                }
            }
            else
            {
                if (t == true)
                {
                    answer = 3;
                }
                else
                {
                    if (f == true)
                    {
                        answer = 5;
                    }
                    else
                    {
                        answer = 1;
                    }
                }
            }
                // end

                return answer;
        }
        public bool Task8(int year, int pupils, int salary)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) return false;
            double avrors = pupils / 7.0;
            double avrors_ceiling = Math.Ceiling(avrors);

            double new_bank = avrors_ceiling * salary + pupils * 5;

            return new_bank <= 10000;
        }
    }
}

