using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cision.UnitTestDemo.Calculator
{
    public class Calculator : ICalculator
    {
        private readonly IUSD_ExchangeRateFeed _usdExchangeRateFeed;

        public Calculator(IUSD_ExchangeRateFeed usdExchangeRateFeed)
        {
            _usdExchangeRateFeed = usdExchangeRateFeed;
        }

        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        public int Subtract(int number1, int number2)
        {
            return 0;
        }
        public int Multipy(int number1, int number2)
        {
            return 0;
        }
        public int Divide(int number1, int number2)
        {
            return 0;
        }
        public int ConvertUSD(int unit)
        {
            return unit * _usdExchangeRateFeed.GetActualUSDValue();
        }
    }
}
