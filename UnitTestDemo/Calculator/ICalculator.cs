namespace Cision.UnitTestDemo.Calculator
{
    public interface ICalculator
    {
        int Add(int number1, int number2);
        int Subtract(int number1, int number2);
        int Multipy(int number1, int number2);
        int Divide(int number1, int number2);
        int ConvertUSD(int unit);
    }
}