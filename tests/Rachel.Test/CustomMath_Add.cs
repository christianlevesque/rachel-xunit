using System;
using Rachel.Service;
using Xunit;

namespace Rachel.Test;

public class CustomMath_Add
{
    private readonly CustomMath _math;

    public CustomMath_Add()
    {
        _math = new CustomMath();
    }

    [Fact]
    public void Add_ReturnsAccurateResult_WhenNumbersInRange()
    {
        var n1 = 2;
        var n2 = 2;
        var expected = 4;
        var actual = _math.Add(n1, n2);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Add_DoesntReturnInaccurateResult_Ever()
    {
        var n1 = 2;
        var n2 = 2;
        var notExpected = 5;
        var actual = _math.Add(n1, n2);

        Assert.NotEqual(notExpected, actual);
    }

    [Fact]
    public void Add_Throws_WhenNumbersOutOfRange()
    {
        var n1 = int.MaxValue;
        var n2 = 1;

        Assert.Throws<Exception>(() => _math.Add(n1, n2));
    }

    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(3, 3, 6)]
    [InlineData(1, 1, 2)]
    public void Add_ReturnsAccurateResults_WhenMoreNumbersInRange(int a, int b, int expected)
    {
        var actual = _math.Add(a, b);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2, 2, 5)]
    [InlineData(3, 3, 5)]
    [InlineData(1, 1, 5)]
    public void Add_DoesntReturnInaccurateResult_WithMoreNumbersEver(int a, int b, int notExpected)
    {
        var actual = _math.Add(a, b);
        Assert.NotEqual(notExpected, actual);
    }
}