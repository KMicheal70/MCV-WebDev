namespace Calculator
{
    public class BasicCalcOp : IBasicCalcOp
    {
        public double Add(params double[] arr)
        {
            double result = 0;
            foreach (double i in arr)
            {
                result += i;
            }
            return result;
        }
        public double Minus(params double[] arr)
        {
            double result = arr[0];
            foreach (double i in arr)
            {
                if (i == arr[0]) { continue; }
                result -= i;
            }
            return result;
        }
        public double Multiply(params double[] arr)
        {
            double result = arr[0];
            foreach (double i in arr)
            {
                if (i == arr[0]) { continue; }
                result *= i;
            }
            return result;
        }
        public double Divide(params double[] arr)
        {
            double result = arr[0];
            foreach (double i in arr)
            {
                if (i == arr[0]) { continue; }
                result /= i;
            }
            return result;
        }
        public double Percentage(double nominator, double total)
        {
            double result = nominator / total;
            result *= 100;
            result = Math.Round(result);
            return result;
        }

        public bool isEvenOrOdd(double num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}