using System.Net.NetworkInformation;

namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            // code here
            if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c < 0))
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            // code here
            if (a == 0 ^ b == 0) // 0%int==0 int!=0
            {
                answer = true; 
            }
            else
            {
                int fnum = Math.Max(Math.Abs(a), Math.Abs(b)); //number with bigger abs value
                int snum = Math.Min(Math.Abs(a), Math.Abs(b)); //number with smaller abs value
                answer = fnum % snum == 0;
            }

            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here

            if (Math.Pow(Math.Min(a, b), 2.00) == Math.Max(a, b) || Math.Pow(Math.Min(a, b), 3.00) == Math.Max(a, b))
            {
                answer = true;
            }
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            answer = f * f - (4 * d * g);
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1)
            {
                answer = 1;
                
            }
            else if (x <= 1)
            {
                answer = -x;
            }
            else if (x > 1)
            {
                answer = -1;
            }
            // end

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            // code here
            const double Pi = Math.PI;
            double diagonal = Math.Sqrt(2*squareS);
            if (diagonal * diagonal * Pi / 4 <= circleS)
            {
                answer = true;
            }
            // end

            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            // code here
            if (s)
            {
                if (t)
                {
                    answer = 6;
                }
                else
                {
                    if (f)
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
                if (t)
                {
                    answer = 3;
                }
                else
                {
                    if (f)
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
            bool answer = false;
            const int bank = 10000;

            // code here
            //amount of money needed
            double groups = (double)pupils / 7;
            int avrors = (int)Math.Ceiling(groups);
            int money_total = avrors * salary + pupils * 5;

            //is leap year
            bool is_leap = false;
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                is_leap = true;
            }
            System.Console.WriteLine(is_leap);

            //answer
            answer = (money_total <= bank) && (is_leap==false);
            // end

            return answer;
        }
    }
}