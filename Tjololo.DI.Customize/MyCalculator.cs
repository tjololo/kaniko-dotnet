using Tjololo.DI.Interfaces;

namespace Tjololo.DI.Customize;

[Transient(typeof(PercentageCalculator))]
public class MyCalculator : PercentageCalculator
{
    public double AddPercentage(double number)
    {
       return number * 1.30;
    }
}