using System.ComponentModel;
using System.Formats.Asn1;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Lab1
{
    public class Purple
    {


        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            // code here

            // Ну, если уж я пурпуль, то надо не скучать :>

            static int f(int x)
            {
                if (x == 0) return 0;
                if (x > 1) return 1;
                return -1;
            }

            answer = f(a) == f(b) && f(b) == f(c);

            // end

            return answer;
        }
        public bool Task2(int a, int b)
        {
            bool answer = false;

            // code here

            var can_a_by_b = b != 0 && a % b == 0;
            var can_b_by_a = a != 0 && b % a == 0;
            answer = can_a_by_b || can_b_by_a;

            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here

            static bool is_root_of_2(int x, int y) => x * x == y;

            static bool is_root_of_3(int x, int y) => x * x * x == y;

            static bool check(int x, int y) => is_root_of_2(x, y) || is_root_of_3(x, y);

            answer = check(a, b) || check(b, a);

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

            static double y(double a)
            {
                if (a <= -1) return 1;
                if (a > 1) return -1;
                return -a;
            }

            answer = y(x);

            // end

            return answer;
        }
        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            // code here

            var square_side = Math.Sqrt(squareS);
            var circle_radius = Math.Sqrt(circleS / Math.PI); // cs / pi = r * r

            answer = Math.Sqrt(2.0) * square_side <= circle_radius * 2.0;

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

            static bool check_year(int y)
            {
                return (y % 400 == 0 || y % 100 != 0) && y % 4 == 0;
            }

            bool solve()
            {
                bool is_bad_year = check_year(year);
                if (is_bad_year) return false;

                var aurs = (pupils + 6) / 7;

                var money_waste_total = salary * aurs + 5 * pupils;

                return money_waste_total <= bank;
            }

            answer = solve();

            // end

            return answer;
        }
    }
}