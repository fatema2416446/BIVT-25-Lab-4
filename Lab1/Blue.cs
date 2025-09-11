using System.Threading.Channels;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;


            // code here
            if ((a > 0) && (b > 0))
                answer = true;
            else if ((a < 0) && (b < 0))
                answer = true;
            else if ((a == b) && (b == 0))
                answer = true;


                // end

                return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            d = Math.Abs(d);
            if (((d % 1)*10000) >= 1)
                    answer = true;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if ((b != 0) && (a % b == 0))
                answer = true;
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
            if ((d1 >= f1) && (d1 >= g1))
                answer = d;
            else if ((f1 >= d1) && (f1 >= g1))
                answer = f;
            else if ((g1 >= f1) && (g1 >= d1))
                answer = g;
            
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1)
                answer = 0;
            else if ((x <= 0) && (x > -1))
                answer = x + 1;
            else
            {
                answer = 1;
            }

            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double x = Math.Pow(squareS, 0.5);
            double r = Math.Pow((circleS / Math.PI), 0.5);
            if ((squareS >= circleS) && (x >= (2 * r)))
                answer = true;
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
                    answer = -1;
            }
            else
            {
                if (f > 0)
                    answer = 1;
            }

                // end

                return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            double a1 = a / 2;
            double b1 = b / 2;
            double c1 = c / 2;
            int mid_a = (int)Math.Floor(a1);
            int mid_b = (int)Math.Floor(b1);
            int mid_c = (int)Math.Floor(c1);
            if ((mid_a + mid_b + mid_c) >= 3)
            {
                if ((mid_a + mid_b + mid_c) % 3 == 0)
                    answer = true;
                else if ((mid_a + mid_b + mid_c) % 3 == 2) // добавил монету младшему
                    answer = true;
            }
            else if ((mid_a + mid_b + mid_c) == 2) // добавил монету младшему
                answer = true;


                // end

                return answer;
        }
    }
}