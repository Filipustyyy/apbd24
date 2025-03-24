namespace Cwiczenia3;

public class CargoShip
{
    public double MaxSpeed;
    public int MaxContainers;
    public double MaxWeight;
    private List<Container> Containers;

    public CargoShip(double maxSpeed, int maxContainers, double maxWeight)
    {
        MaxSpeed = maxSpeed;
        MaxContainers = maxContainers;
        MaxWeight = maxWeight;
        Containers = new List<Container>();
    }

    public void LoadC(Container container)
    {
        if (Containers.Count >= MaxContainers || Containers.Sum(c => c.ContainerWeight + c.LoadWeight) + container.ContainerWeight + container.LoadWeight > MaxWeight)
            throw new OverfillException("Ship overload error.");
        Containers.Add(container);
    }

    public void UnloadC(Container container)
    {
        Containers.Remove(container);
    }

    public void ReplaceC(Container oldC, Container newC)
    {
        UnloadC(oldC);
        LoadC(newC);
    }

    public void TransferC(Container container, CargoShip targetShip)
    {
        {
            UnloadC(container);
            targetShip.LoadC(container);
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Ship info: Max Speed {MaxSpeed}, Max Containers {MaxContainers}, Max Load Weight {MaxWeight} tons");
        Console.WriteLine("Loaded containers:");
        foreach (var container in Containers)
        {
            Console.WriteLine($"{container.SerialNumber}");
        }
    }
}