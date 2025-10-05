namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer;
            //code here
            if (a == 0 || b == 0)
                answer = false;
            else
                answer = (a > 0 && b > 0) || (a < 0 && b < 0);
            //end
            return answer;
        }

        public bool Task2(double d)
        {
            bool answer;
            //code here
            answer = Math.Abs(d - Math.Floor(d)) >= 0.0001;
            //end
            return answer;
        }

        public bool Task3(int a, int b)
        {
            bool answer;
            //code here
            if (b == 0)
                answer = false;
            else
                answer = a % b == 0;
            //end
            return answer;
        }

        public double Task4(double d, double f, double g)
        {
            double answer;
            //code here
            double absD = Math.Abs(d);
            double absF = Math.Abs(f);
            double absG = Math.Abs(g);

            if (absD >= absF && absD >= absG)
                answer = d;
            else if (absF >= absG)
                answer = f;
            else
                answer = g;
            //end
            return answer;
        }

        public double Task5(double x)
        {
            double answer;
            //code here
            if (x <= -1)
                answer = 0;
            else if (x > -1 && x <= 0)
                answer = x + 1;
            else
                answer = 1;
            //end
            return answer;
        }

        public bool Task6(double circleS, double squareS)
        {
            bool answer;
            //code here
            // Circle area = π * r²
            // Square area = side²
            // Circle fits in square if diameter ≤ side
            // So: 2*r ≤ side
            // r = sqrt(circleS / π), side = sqrt(squareS)
            double radius = Math.Sqrt(circleS / Math.PI);
            double side = Math.Sqrt(squareS);
            answer = 2 * radius <= side;
            //end
            return answer;
        }

        public bool Task7(double d, double f)
        {
            bool answer;
            //code here
            // Circuit logic for Blue League Task 7
            answer = (d > 0 && f > 0) || (d <= 0 && f <= 0);
            //end
            return answer;
        }

        public bool Task8(int a, int b, int c)
        {
            bool answer;
            //code here
            // Each bag is half full: a/2, b/2, c/2 coins
            int coinsA = a / 2;
            int coinsB = b / 2;
            int coinsC = c / 2;

            int totalCoins = coinsA + coinsB + coinsC;

            // King can add 1 coin to youngest son's bag
            int maxPossibleCoins = totalCoins + 1;

            // For equal distribution, each bag needs the same amount
            // Check if we can distribute equally with at least 1 coin per bag
            if (maxPossibleCoins % 3 == 0 && maxPossibleCoins / 3 >= 1)
            {
                int coinsPerBag = maxPossibleCoins / 3;
                // Check if we can achieve this distribution
                answer = (coinsPerBag <= a) && (coinsPerBag <= b) && (coinsPerBag <= c + 1);
            }
            else
            {
                answer = false;
            }
            //end
            return answer;
        }
    }
}
