namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if ( (a*b > 0) | (a==0 & b == 0) ) { answer = true; }
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            if (d - (int)d != 0)
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
            if ( b != 0){
                if (a % b == 0) { answer = true; }
            }
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;
            
            // code here
 
            double mx = Math.Max(Math.Abs(d), Math.Max( Math.Abs(f), Math.Abs(g)) );
            if (mx == Math.Abs(d))
            {
                answer = d;
            }
            else if (mx == Math.Abs(f))
            {
                answer = f;
            }
            else if (mx == Math.Abs(g))
            {
                answer = g;
            }
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
            else if (-1 < x & x <= 0)
            {
                answer = x + 1;
            }
            else if (x > 0)
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
            double r = Math.Sqrt(circleS/Math.PI);
            double l = Math.Sqrt(squareS);
            if (2*r <= l)
            {
                answer = true;
            }
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
                if (f> 0) answer = 1;
            }
                // end

                return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int val_a = (int)a / 2;
            int val_b = (int)b / 2;
            int val_c = (int)c / 2;
            double total = val_a + val_b + val_c;
            int mn = Math.Min(a, Math.Min(c,b));
            double d = Double.Ceiling(total/3);
            if (d*3 - total <= 1 && d>0 && d <= mn)
            {
                answer = true;
            }
            // end

            return answer;
        }
    }
}