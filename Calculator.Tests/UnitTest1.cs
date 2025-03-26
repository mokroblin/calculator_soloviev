using Xunit;
using calculator_soloviev;
using System;

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

    [Fact]
    public void Multiply_ShouldReturnCorrectProduct()
    {
        double num1 = 4;
        double num2 = 2;
        char operation = '*';
        double expected = 8;

        double result = Program.Calculate(num1, num2, operation);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Divide_ShouldReturnCorrectQuotient()
    {
        double num1 = 10;
        double num2 = 2;
        char operation = '/';
        double expected = 5;

        double result = Program.Calculate(num1, num2, operation);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void DivideByZero_ShouldThrowDivideByZeroException()
    {
        double num1 = 10;
        double num2 = 0;
        char operation = '/';

        // Действие и утверждение
        Assert.Throws<DivideByZeroException>(() => Program.Calculate(num1, num2, operation));
    }

    [Fact]
    public void InvalidOperator_ShouldThrowInvalidOperationException()
    {
        double num1 = 10;
        double num2 = 2;
        char operation = '%';

        Assert.Throws<InvalidOperationException>(() => Program.Calculate(num1, num2, operation));
    }
}
