namespace Cwiczenia3;
    
public class Container
{
    public static int LastSerialNum = 0;
    public double LoadWeight;
    public double ContainerWeight;
    public double Height;
    public double Depth;
    public string SerialNumber;
    public readonly double MaxLoadWeight;
    public CType Type;

    public Container(double maxLoadWeight, double containerWeight, double height, double depth, CType type)
    {
        this.MaxLoadWeight = maxLoadWeight;
        this.ContainerWeight = containerWeight;
        this.Height = height;
        this.Depth = depth;
        this.Type = type;
        this.LoadWeight = 0;
        this.SerialNumber = GenerateSerial(type);
    }

    private string GenerateSerial(CType type)
    {
        char typeChar;
        if (type == CType.GAS)
            typeChar = 'G';

        else if (type == CType.REFRIGERATED)
            typeChar = 'R';
        
        else
            typeChar = 'L';
            
        return $"KON-{typeChar}-{LastSerialNum++}";
    }

    public void Unload()
    {
        LoadWeight = 0;
    }

    public void Load(double loadWeight, double maxAllowed)
    {
        if (this.LoadWeight != 0)
        {
            Console.WriteLine("already something here");
            return;
        }
        else if (loadWeight > maxAllowed)
        {
            throw new OverfillException("Load weight is greater than max load weight");
        }
        else
        {
            this.LoadWeight = loadWeight;
        }
    }
}