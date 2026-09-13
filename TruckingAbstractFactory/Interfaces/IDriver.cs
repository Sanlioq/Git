namespace TruckingAbstractFactory.Interfaces
{
    public interface IDriver
    {
        string Name { get; }
        string Nationality { get; }
        int ExperienceYears { get; }
        string LicenseCategory { get; }

        void DriveRoute(string from, string to);
        void RestAtStop();
        string GetDriverInfo();
    }
}
