using System;
using System.Collections.Concurrent;

namespace Rachel.Service;

/// <summary>
/// Implements custom math functionality that .NET doesn't include by defaultß
/// </summary>
public class CustomMath
{
    /// <summary>
    /// Adds two numbers
    /// </summary>
    /// <param name="a">the first addend</param>
    /// <param name="b">the second addend</param>
    /// <returns>the sum of the two addends</returns>
    public int Add(int a, int b)
    {
        var result = a + b;
        if (result < 0)
        {
            throw new Exception($"Result too large for {typeof(int)} data type");
        }

        return result;
    }

    /// <summary>
    /// Subtracts one number from another
    /// </summary>
    /// <param name="a">the minuend</param>
    /// <param name="b">the subtrahend</param>
    /// <returns>the difference of the two numbersß</returns>
    public int Subtract(int a, int b) => a - b;
}