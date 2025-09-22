using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if ((a>0 && b>0) || (b<0 && a<0))
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
            if (Math.Abs(d)%1!=0)
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
            if (Math.Max(d1, Math.Max(f1, g1)) == d1) { answer = d; }
            else if (Math.Max(d1, Math.Max(f1, g1)) == f1) { answer = f; }
            else if (Math.Max(d1, Math.Max(f1, g1)) == g1) { answer = g; }
                ;
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x<=-1)
            {
                answer = 0;
            }
            else if (x > -1 && x <= 0)
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
            if (circleS*4/Math.PI <= squareS)
            {
                answer=true;
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
                if (d > 0)
                {
                    answer = -1;
                } 
            }
            else 
            {
                if (f>0)
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
            int a1 = a / 2;
            int b2 = b / 2;
            int c2= c / 2;
            int cnt = a1 + b2 + c2;
            if (cnt % 3 == 0 && cnt > 0) 
            {
                answer = true;
            }
            else
            {
                cnt += 1;
                if (cnt % 3 == 0 && cnt > 0)
                {
                    answer = true; 
                } 
            }
            // end

                return answer;
        }
    }
}