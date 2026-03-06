using Xunit;
using ConsoleApp;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        // Arrange
        var calc = new Calculator();

        // Act
        int result = calc.Add(20, 3);

        // Assert
        Assert.Equal(23, result);
    }
}