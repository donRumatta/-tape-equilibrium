using TapeEquilibrium;

namespace Tests;

public class CalculatorTests
{
    [Test]
    public void Calculator_CalculateDiff()
    {
        var result = Calculator.CalculateDiff([3, 1, 2, 4, 3]);

        Assert.AreEqual(1, result);
    }
    
    [Test]
    public void Calculator_Calculate_Short()
    {
        var result = Calculator.CalculateDiff([3, 1]);

        Assert.AreEqual(2, result);
    }
    
    [Test]
    public void Calculator_Calculate_Negative()
    {
        var result = Calculator.CalculateDiff([-1000, 1000]);

        Assert.AreEqual(2000, result);
    }
}