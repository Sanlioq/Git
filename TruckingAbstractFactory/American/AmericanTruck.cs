using TruckingAbstractFactory.Interfaces;

namespace TruckingAbstractFactory.American
{
    public class AmericanTruck : ITruck
    {
        public string Model => "Peterbilt 389";
        public int HorsePower => 600;
        public int CargoCapacityTons => 22;

        public void StartEngine()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"  [{Model}] Cummins X15 гуде на весь хайвей! Let's roll!");
            Console.ResetColor();
        }

        public void LoadCargo(string cargoDescription)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"  [{Model}] Loading: {cargoDescription}. Using dock leveler at warehouse.");
            Console.ResetColor();
        }

        public string GetSpecifications()
        {
            return $"  Вантажівка: {Model}\n" +
                   $"  Потужність: {HorsePower} к.с.\n" +
                   $"  Вантажопідйомність: {CargoCapacityTons} тонн\n" +
                   $"  Стандарт: EPA 2010 (США)\n" +
                   $"  Підвіска: Ресорна (класика)\n" +
                   $"  GPS: Rand McNally ELD";
        }
    }
}
