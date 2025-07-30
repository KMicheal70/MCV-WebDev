namespace Calculator
{
    public interface IBasicCalcOp
    {
        public double Add(params double[] arr);
        public double Minus(params double[] arr);
        public double Multiply(params double[] arr);
        public double Divide(params double[] arr);
        public double Percentage(double nominator, double total);

        public bool isEvenOrOdd(double num);
    }
}