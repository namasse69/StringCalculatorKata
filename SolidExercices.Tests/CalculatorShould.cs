using NFluent;
using NUnit.Framework;

namespace SolidExercices.Tests
{
    public class CalculatorShould
    {
        [Test]
        public void CalculateASum()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("1+2,3");
            Check.That(result).IsEqualTo(3.3m);
        }

        public void CalculateASub()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("4-2");
            Check.That(result).IsEqualTo(2m);
        }

        public void CalculateAProd()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("2*4");
            Check.That(result).IsEqualTo(8m);
        }

        public void CalculateADiv()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("6/3");
            Check.That(result).IsEqualTo(2m);
        }
        public void CalculateMultiProd()
        {
            var calculator = new Calculator();
            var result = calculator.Calculate("6*4*2.5");
            Check.That(result).IsEqualTo(60m);
        }
    }
}
