using Tjololo.DI.Interfaces;

namespace Tjololo.DI.Customize;

[Transient(typeof(IPercentage))]
public class MyImplementation: IPercentage
{
    public double GetValue()
    {
        return 1.35;
    }
}