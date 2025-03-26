using Xunit;
using calculator_soloviev;

public class CalculatorTests
{
    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        // Организация
        double num1 = 5;
        double num2 = 3;
        char operation = '+';
        double expected = 8;

        // Действие
        double result = Program.Calculate(num1, num2, operation);

        // Утверждение
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Subtract_ShouldReturnCorrectDifference()
    {
        double num1 = 5;
        double num2 = 3;
        char operation = '-';
        double expected = 2;

        double result = Program.Calculate(num1, num2, operation);

        Assert.Equal(expected, result);
    }

}
