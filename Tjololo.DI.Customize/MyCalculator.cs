using Tjololo.DI.Interfaces;

namespace Tjololo.DI.Customize;

[Transient(typeof(PercentageCalculator))]
public class MyCalculator : PercentageCalculator
{
    private PercentageCalculator _percentage;
    
    public MyCalculator(PercentageCalculator percentage)
    {
        _percentage = percentage;
    }
    
    public double AddPercentage(double number)
    {
        //My prelogic
        return _percentage.AddPercentage(number);
        //My postlogic
    }
}