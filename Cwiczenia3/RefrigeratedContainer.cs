namespace Cwiczenia3;

public class RefrigeratedContainer : Container
{
    public string ProductType;
    public double Temperature;
    
    public RefrigeratedContainer(double maxLoadWeight, double containerWeight, double height, double depth, string ptype, double temp)
        : base(maxLoadWeight, containerWeight, height, depth, CType.REFRIGERATED)
    {
        ProductType = ptype;
        Temperature = temp;
    }
    
    public void Load(double loadWeight)
    {
        base.Load(loadWeight, MaxLoadWeight);
    }
    
}