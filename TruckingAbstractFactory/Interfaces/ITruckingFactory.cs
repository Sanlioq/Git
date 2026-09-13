namespace TruckingAbstractFactory.Interfaces
{
    public interface ITruckingFactory
    {
        string CompanyName { get; }
        string Region { get; }

        ITruck CreateTruck();
        IDriver CreateDriver();
        ICargo CreateCargo();
    }
}
