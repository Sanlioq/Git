namespace TruckingAbstractFactory.Interfaces
{
    public interface ITruck
    {
        string Model { get; }
        int HorsePower { get; }
        int CargoCapacityTons { get; }

        void StartEngine();
        void LoadCargo(string cargoDescription);
        string GetSpecifications();
    }
}
