namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a > 0 && b > 0) || (a < 0 && b < 0))
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
            int x = (int)d;
            if ((d - x) != 0)
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
            if (b != 0 && a % b == 0)
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
            double d1 = Math.Abs(d);
            double f1 = Math.Abs(f);
            double g1 = Math.Abs(g);

            //можно списком, но раз уж мы с !базы!😦 начинаем то куча if else
            if (d1 >= f1 && d1 >= g1) answer = d;
            else if (f1 >= d1 && f1 >= g1) answer = f;
            else answer = g;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1) answer = 0;
            else if (-1 < x && x <= 0) answer = x + 1; //почему-то -0.55 метод возвращает -0.44999999999999 ээээ хотя всё правильно
            else if (x > 0) answer = 1;
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double radiusOfCircle = circleS / Math.PI;
            if (radiusOfCircle * 2 <= Math.Pow(squareS, 0.5)) answer = true;
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
            int sum = (int)Math.Floor((double)a / 2) + (int)Math.Floor((double)b / 2) + (int)Math.Floor((double)c / 2);
            if (sum % 3 == 0 || sum % 3 == 2) answer = true;
            // end

            return answer;
        }
    }

}
