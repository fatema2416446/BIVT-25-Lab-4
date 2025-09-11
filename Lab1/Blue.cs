namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            var c = a * b;
            answer=(c > 0);
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            d = d * d;
            int a = (int) d;
            answer = (d > a);
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            int c = 1;
            if (b != 0)
            {
                c = a % b;
            }
            
            answer = (c == 0);
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double a, b, c;
            a = Math.Abs(d);
            b = Math.Abs(f);
            c = Math.Abs(g);
            answer = d;
            if (Math.Abs(answer) < b)
                answer = f;
            if (Math.Abs(answer) < c)
                answer = g;
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
            else
            {
                if (x > 0)
                {
                    answer = 1;
                }
                else
                {
                    answer = x + 1;
                }
            }
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double r = Math.Sqrt(circleS / Math.PI);
            double a = Math.Sqrt(squareS);
            answer = (2 * r <= a);
            
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
            int ha=a/2, hb=b/2, hc=c/2;
            int obsh = ha + hb + hc;
            int cr = obsh / 3;
            int ost = obsh % 3;

            if (cr < a && cr < b && cr < c && ost == 2)
                answer = true;
            if (cr <= a  &&  cr <= b && cr <= c)
            {
                if (ost == 1)
                    answer = false;
                if (ost == 0)
                    answer = true;
            }
            if (a==0 || b==0 || c==0)
                answer = false;
            
            // end

            return answer;
        }
    }
}