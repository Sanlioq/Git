using TruckingAbstractFactory.Interfaces;

namespace TruckingAbstractFactory.American
{
    public class AmericanDriver : IDriver
    {
        public string Name => "Бобі Джексон";
        public string Nationality => "Американець";
        public int ExperienceYears => 20;
        public string LicenseCategory => "CDL Class A + HAZMAT";

        public void DriveRoute(string from, string to)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"  [{Name}] Route: {from} -> {to}");
            Console.WriteLine($"  HOS (Hours of Service): 11 год руху, 10 год відпочинку. ELD обов'язково.");
            Console.ResetColor();
        }

        public void RestAtStop()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"  [{Name}] 30-хв перерва на truck stop. Кава + бургер.");
            Console.ResetColor();
        }

        public string GetDriverInfo()
        {
            return $"  Водій: {Name}\n" +
                   $"  Національність: {Nationality}\n" +
                   $"  Досвід: {ExperienceYears} років\n" +
                   $"  Категорія: {LicenseCategory}\n" +
                   $"  Мови: Англійська, Іспанська\n" +
                   $"  ELD: Certified (FMCSA)";
        }
    }
}
