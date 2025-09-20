using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            double f = Math.Abs(d);
            answer = f >= 1;

            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            double sum = (d + f) / 2;
            answer = sum > 0;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            int sum = a + b;
            double sr_znach = (Math.Abs(a) + Math.Abs(b)) / 2;
            answer = sum > sr_znach;
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            answer = Math.Max(a, Math.Max(b, c));

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            double mod = Math.Abs(x);
            if (mod > 1)
            {
                answer = 0;
            }
            else
            {
                answer = x * x - 1;
            }

            // end

                return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;
            
            // code here
            double y1;

            if (x < 0)
            {
                y1 = 1 + x;
            }
            else
            {
                y1 = 1 - x;
            }
            if (y <= y1 && y >= 0)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
                            

            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here

            if (n < 0)
            {
                answer = false;
                return answer;
            }
            else
            {
                if (n % 2 == 0)
                {
                    
                    answer = false;
                }
                else
                {
                    return answer;
                }
            }

            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here

            if (X >= 7)
            {
                double Y1 = Y;
                double sleep_beg = 4;
                double sleep_end = 7;
                if (X % 2 == 0)
                {
                    sleep_beg = sleep_beg - (X / 2) * (Y1 / 60);
                    //Console.WriteLine();
                    Console.WriteLine((X / 2));
                    Console.WriteLine((Y / 60));
                    Console.WriteLine((X / 2) * (Y1 / 60));
                    Console.WriteLine(sleep_beg);
                }
                else
                {
                    sleep_beg = sleep_beg - ((X + 1) / 2) * (Y / 60);
                }
                Console.WriteLine(sleep_end);
                if (7.0 <= sleep_end - sleep_beg && sleep_end - sleep_beg <= 9.0)
                {
                    answer = true;
                }
                
                 
            }


            // end

            return answer;
        }
    }
}