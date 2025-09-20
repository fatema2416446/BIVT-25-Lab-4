 

namespace Lab1
{
    public class White
    {
        public bool Task1(double d)
        {
            bool answer = false;

            if(d > 0)
                answer = true;
            
                return answer;
        }
        public bool Task2(int n)
        {
            bool answer = false;
            if (n % 2 == 0)
                answer = true;
            return answer;
        }
        public int Task3(int a, int b)
        {
            if (a > b)
            {
                return a;
            }

            else
            {
                return b;
            }
        }


        public double Task4(double d, double f)
        {
            if (Math.Abs(d) > Math.Abs(f))
            {
                return f;
            }

            else
            {
                return d;
            }
        }
        public double Task5(double x)
        {
            double answer = 0;

            if(Math.Abs(x) > 1)
            {
                answer = 1;
            }
            if (Math.Abs(x) <= 1)
            {
                answer = x;
            }
             return answer;   
        }
        public bool Task6(double x, double y, double r)
        {
            bool answer = false;
            if(Math.Abs((Math.Pow(x, 2) +  Math.Pow(y, 2) - Math.Pow(r, 2))) <= Math.Pow(10, -4))
            {
                answer =  true;
            }
            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = false;
            double s = Math.Pow(n, 2);
            if(((s - n) > 2 * n) & ( n % 2 == 0 ))
            {
                answer = true;
            }

            return answer;
        }
        public bool Task8(double L, int T, int M)
        {
            bool answer = false;

           if ((L <= 3 * 10) && (T + M >= 5) && (M % 2 == 0))
            {
                answer = true;
            }
            return answer;
        }
    }
}