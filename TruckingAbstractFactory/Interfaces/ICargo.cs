namespace TruckingAbstractFactory.Interfaces
{
    public interface ICargo
    {
        string CargoType { get; }
        double WeightTons { get; }
        string PackagingType { get; }
        bool RequiresRefrigeration { get; }

        void PrepareForShipping();
        void CheckCondition();
        string GetCargoManifest();
    }
}
