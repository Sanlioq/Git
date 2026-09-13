using TruckingAbstractFactory.Interfaces;

namespace TruckingAbstractFactory.European
{
    public class EuropeanDriver : IDriver
    {
        public string Name => "Ганс Мюллер";
        public string Nationality => "Німець";
        public int ExperienceYears => 15;
        public string LicenseCategory => "CE + ADR";

        public void DriveRoute(string from, string to)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"  [{Name}] Маршрут: {from} -> {to}");
            Console.WriteLine($"  Дотримання режиму праці та відпочинку (EU 561/2006)");
            Console.ResetColor();
        }

        public void RestAtStop()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"  [{Name}] Обов'язковий відпочинок 45 хв. Зупинка: автостоянка TIR.");
            Console.ResetColor();
        }

        public string GetDriverInfo()
        {
            return $"  Водій: {Name}\n" +
                   $"  Національність: {Nationality}\n" +
                   $"  Досвід: {ExperienceYears} років\n" +
                   $"  Категорія: {LicenseCategory}\n" +
                   $"  Мови: Німецька, Англійська\n" +
                   $"  Карта водія: Цифровий тахограф EU";
        }
    }
}
