using TruckingAbstractFactory.Interfaces;

namespace TruckingAbstractFactory.Ukrainian
{
    public class UkrainianDriver : IDriver
    {
        public string Name => "Микола Бондаренко";
        public string Nationality => "Українець";
        public int ExperienceYears => 18;
        public string LicenseCategory => "C+E (CE) + ADR";

        public void DriveRoute(string from, string to)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"  [{Name}] Маршрут: {from} -> {to}");
            Console.WriteLine($"  Митне оформлення: T1, ЕРД. Перетин кордону: 4-6 годин.");
            Console.ResetColor();
        }

        public void RestAtStop()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"  [{Name}] Зупинка на відпочинок. Термос із борщем — must have!");
            Console.ResetColor();
        }

        public string GetDriverInfo()
        {
            return $"  Водій: {Name}\n" +
                   $"  Національність: {Nationality}\n" +
                   $"  Досвід: {ExperienceYears} років\n" +
                   $"  Категорія: {LicenseCategory}\n" +
                   $"  Мови: Українська, Польська, Англійська\n" +
                   $"  Тахограф: Аналоговий / Цифровий";
        }
    }
}
