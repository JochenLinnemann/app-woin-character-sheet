using FluentAssertions;

namespace WoinRules.Tests;

public class TriangularNumbersTest
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 2)]
    [InlineData(5, 2)]
    [InlineData(6, 3)]
    [InlineData(7, 3)]
    [InlineData(8, 3)]
    [InlineData(9, 3)]
    [InlineData(10, 4)]
    [InlineData(11, 4)]
    [InlineData(12, 4)]
    [InlineData(13, 4)]
    [InlineData(14, 4)]
    [InlineData(15, 5)]
    [InlineData(16, 5)]
    [InlineData(17, 5)]
    [InlineData(18, 5)]
    [InlineData(19, 5)]
    [InlineData(20, 5)]
    [InlineData(21, 6)]
    [InlineData(22, 6)]
    [InlineData(23, 6)]
    [InlineData(24, 6)]
    [InlineData(25, 6)]
    [InlineData(26, 6)]
    [InlineData(27, 6)]
    [InlineData(28, 7)]
    public void CalculateDicePoolSize_Returns_ExpectedDicePoolSize(int value, int expectedDicePoolSize)
    {
        TriangularNumbers.CalculateDicePoolSize(value).Should().Be(expectedDicePoolSize);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 3)]
    [InlineData(3, 6)]
    [InlineData(4, 10)]
    [InlineData(5, 15)]
    [InlineData(6, 21)]
    [InlineData(7, 28)]
    public void CalculateMinimumValue_Returns_ExpectedMinimumValue(int dicePoolSize, int expectedMinimumValue)
    {
        TriangularNumbers.CalculateMinimumValue(dicePoolSize).Should().Be(expectedMinimumValue);
    }
}