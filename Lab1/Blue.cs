namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a > 0 && b > 0) || (a < 0 && b < 0) || (a == 0 && b == 0)) {answer = true;}
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            if (d != Math.Ceiling(d)) {answer = true;}
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b != 0 && a % b == 0) {answer = true;}    
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            if (Math.Abs(d)  > Math.Abs(f) && Math.Abs(d) > Math.Abs(g))
            {
                answer = d;
            }
            else if ((Math.Abs(f) > Math.Abs(d) && Math.Abs(f) > Math.Abs(g))) 
            {
                answer = f;
            }
            else { answer = g;}
                // end

                return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= - 1)
            {
                answer = 0;
            }
            else if (-1 < x && x <= 0)
            {
                answer = x + 1;
            }
            else { answer = 1; }
                // end

                return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            // Нашли диаметр окр на нижней строке 
            double d;
            d = 2*Math.Sqrt(circleS / Math.PI);
            double a;
            a = Math.Sqrt(squareS);
            if (d <=a) {answer = true;}
            //  если d диаметр кр <=стороны кв, то круг поместится
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
                    answer = - 1;
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
            a = a / 2;
            b = b / 2;
            c = c / 2;
            int all= a + b + c;
            if (all % 3 == 0 && all >= 3) {
                answer = true;
            }
            else if ((all + 1) % 3 == 0 && (all + 1) >= 3)
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
    }
}