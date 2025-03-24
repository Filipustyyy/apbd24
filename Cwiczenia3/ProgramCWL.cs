namespace Cwiczenia3;

public class ProgramCWL // Centrum Wysylki Ladunkow
{
    static void Main(string[] args)
    {
        CargoShip ship = new CargoShip(30, 5, 10000);
        LiquidContainer liquidContainer = new LiquidContainer(5000, 200, 100, 1000, false);
        GasContainer gasContainer = new GasContainer(4000, 180, 90, 800, 10);
        RefrigeratedContainer refrigeratedContainer = new RefrigeratedContainer(3000, 190, 95, 900, "Bananas", -5);
        
        CargoShip ship2 = new CargoShip(20, 2, 10000);
        LiquidContainer liquidContainer2 = new LiquidContainer(5000, 200, 100, 1000, true);
        
        try
        {
            Console.WriteLine("");
            liquidContainer.Load(3000);
            gasContainer.Load(3500);
            refrigeratedContainer.Load(2500);
            liquidContainer2.Load(2000);

            ship.LoadC(liquidContainer);
            ship.LoadC(gasContainer);
            ship.LoadC(refrigeratedContainer);

            ship.PrintInfo();

            ship.UnloadC(refrigeratedContainer);
            Console.WriteLine("");
            ship.PrintInfo();
            
            ship2.LoadC(liquidContainer2);
            ship.TransferC(liquidContainer, ship2);
            Console.WriteLine("");
            ship2.PrintInfo();
        }
        catch (Exception except)
        {
            Console.WriteLine($"Error: {except.Message}");
        }
    }
}