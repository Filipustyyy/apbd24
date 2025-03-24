namespace Cwiczenia3;

public class LiquidContainer : Container, IHazardNotifier
{
    private bool isHazard;
    public LiquidContainer(double maxLoadWeight, double containerWeight, double height, double depth, bool isHazard)
        : base(maxLoadWeight, containerWeight, height, depth, CType.LIQUID)
    {
        this.isHazard = isHazard;
    }

    public void Load(double loadWeight)
    {
        double maxAllowed;
        if (this.isHazard)
        {
            maxAllowed = MaxLoadWeight * 0.5;
        }
        else
        {
            maxAllowed = MaxLoadWeight * 0.9;
        }
            

        if (loadWeight > maxAllowed)
        {
            notify("Load weight exceeds maximum allowed load weight");
        }
        
        base.Load(loadWeight, maxAllowed);
    }
    
    public void notify(string message)
    {
        Console.WriteLine($"Hazard: {message} {SerialNumber}");
    }
}