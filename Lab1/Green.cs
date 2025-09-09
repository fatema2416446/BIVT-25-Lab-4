using System.ComponentModel.DataAnnotations;

namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            if (Math.Abs(d) >= 1)
            {
                answer = true;
            }
            // end

            return answer;
        }

        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            double average = (d + f) / 2;
            if (average > 0)
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
            double average = (Math.Abs(a) + Math.Abs(b)) / 2;
            int sum = a + b;
            if (sum > average)
            {
                answer = true;
            }
            // end

            return answer;
        }

        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            if (a > b && a > c)
            {
                answer = a;
            }
            else if (b > a && b > c)
            {
                answer = b;
            }
            else
            {
                answer = c;
            }
            // end

            return answer;
        }

        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) > 1)
            {
                answer = 0;
            }
            else
            {
                answer = Math.Pow(x, 2) - 1;
            }
            // end

            return answer;
        }

        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            bool isInside = true;
            isInside = isInside && y >= 0;
            isInside = isInside && (x >= -1) && (x <= 1);

            double upper;
            if (x < 0)
            {
                upper = 1 + x;
            }
            else
            {
                upper = 1 - x;
            }

            isInside = isInside && (y <= upper);
            answer = isInside;
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
            }
            else
            {
                if (n % 2 == 0)
                {
                    answer = false;
                }
                else
                {
                    answer = true;
                }
            }
            // end

            return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            int daysLeft = X;
            int currentWakeUp = 14;
            int targetWakeUp = 7;
            //сколько часов нам нужно уменьшить
            int hoursToReduce = currentWakeUp - targetWakeUp;
            //хватит ли дыхательных практик, чтобы наладить подъём
            bool isWakeUpNormal = daysLeft >= hoursToReduce;
            //сколько дней пить чай
            int teaDays = (daysLeft + 1) / 2;
            double teaMinutes = teaDays * Y;
            double teaHours = teaMinutes / 60;
            //хватить ли чая, чтобы наладить время засыпания
            bool isTeaEnough = teaHours >= 4 && teaHours <= 6;
            answer = isWakeUpNormal && isTeaEnough;
            // end

            return answer;
        }
    }
}
