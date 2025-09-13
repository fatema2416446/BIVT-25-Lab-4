using System.ComponentModel.Design;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            answer = ((a > 0 and b > 0) || (a < 0 and b < 0));
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            answer = d % 1 != 0;
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            answer = a % b == 0;
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            absoluteValueForD = Math.Abs(d);
            absoluteValueForF = Math.Abs(f);
            absoluteValueForG = Math.Abs(g);
            if (absoluteValueForD > absoluteValueForF)
            {
                if (absoluteValueForD > absoluteValueForG)
                {
                    answer = d;
                }
                else
                {
                    answer = g;
                }
            else
            {
                if (absoluteValueForF > absoluteValueForG)
                    {
                        answer = f;
                    }
                else
                    {
                        answer = g;
                    }
                }
            }
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1) {
                answer= 0;
            }
            else if (-1 < x && x <= 0) {
                answer = x + 1;
            }
            else {
                answer = 1;
            }
                // end

                return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double dOfCircle = 2 * Math.Sqrt(circleS / Math.PI);  
            double dOfSquare = Math.Sqrt(squareS);
            answer = dOfCircle < dOfSquare
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
            int summAmountOfMoney = a / 2 + b / 2 + c / 2;
            if (summAmountOfMoney % 3 == 0 && summAmountOfMoney / 3 < a
                && summAmountOfMoney / 3 < b && summAmountOfMoney / 3 < c)
            {
                anwer = true;
            }
            else if (summAmountOfMoney % 3 == 2)
            {
                int newSumm = summAmountOfMoney + 1;
                if (newSumm / 3 < a && newSumm / 3 < && newSumm / 3 < c)
                {
                    answer = true
                }
            }
            
                // end

                return answer;
        }
    }
}