using TruckingAbstractFactory.Interfaces;

namespace TruckingAbstractFactory.Ukrainian
{
    public class UkrainianTruck : ITruck
    {
        public string Model => "КрАЗ-6443";
        public int HorsePower => 400;
        public int CargoCapacityTons => 20;

        public void StartEngine()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"  [{Model}] Ярославський дизель заревів! Вперед — на Захід!");
            Console.ResetColor();
        }

        public void LoadCargo(string cargoDescription)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"  [{Model}] Завантаження: {cargoDescription}. Ручне кріплення + брезент.");
            Console.ResetColor();
        }

        public string GetSpecifications()
        {
            return $"  Вантажівка: {Model}\n" +
                   $"  Потужність: {HorsePower} к.с.\n" +
                   $"  Вантажопідйомність: {CargoCapacityTons} тонн\n" +
                   $"  Стандарт: Євро-3\n" +
                   $"  Привід: 6x4\n" +
                   $"  GPS: Wialon / Galileosky";
        }
    }
}
