namespace Cwiczenia3;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure;
    public GasContainer(double maxLoadWeight, double containerWeight, double height, double depth, double pressure)
        : base(maxLoadWeight, containerWeight, height, depth, CType.GAS)
    {
        this.Pressure = pressure;
    }

    public void Load(double loadWeight)
    {
        base.Load(loadWeight, MaxLoadWeight);
    }

    public void Unload()
    {
        LoadWeight = LoadWeight * 0.05;
    }
    
    public void notify(string message)
    {
        Console.WriteLine($"Hazard: {message} at {SerialNumber}");
    }
}