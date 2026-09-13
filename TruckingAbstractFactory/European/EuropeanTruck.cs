using TruckingAbstractFactory.Interfaces;

namespace TruckingAbstractFactory.European
{
    public class EuropeanTruck : ITruck
    {
        public string Model => "Volvo FH16";
        public int HorsePower => 750;
        public int CargoCapacityTons => 25;

        public void StartEngine()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"  [{Model}] Двигун Volvo D16K запущено. Євро-6. Готово до рейсу!");
            Console.ResetColor();
        }

        public void LoadCargo(string cargoDescription)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"  [{Model}] Завантаження: {cargoDescription}. Використовується гідравлічний підйомник.");
            Console.ResetColor();
        }

        public string GetSpecifications()
        {
            return $"  Вантажівка: {Model}\n" +
                   $"  Потужність: {HorsePower} к.с.\n" +
                   $"  Вантажопідйомність: {CargoCapacityTons} тонн\n" +
                   $"  Стандарт викидів: ЄВРО-6\n" +
                   $"  Підвіска: Пневматична\n" +
                   $"  GPS: Volvo Connect";
        }
    }
}
