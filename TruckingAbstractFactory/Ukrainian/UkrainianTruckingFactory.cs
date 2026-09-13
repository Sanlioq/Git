using TruckingAbstractFactory.Interfaces;

namespace TruckingAbstractFactory.Ukrainian
{
    public class UkrainianTruckingFactory : ITruckingFactory
    {
        public string CompanyName => "Укртранс Карго";
        public string Region => "Україна / Схід Європи";

        public ITruck CreateTruck()
        {
            Console.WriteLine("  -> Фабрика створює УКРАЇНСЬКУ вантажівку...");
            return new UkrainianTruck();
        }

        public IDriver CreateDriver()
        {
            Console.WriteLine("  -> Фабрика наймає УКРАЇНСЬКОГО водія...");
            return new UkrainianDriver();
        }

        public ICargo CreateCargo()
        {
            Console.WriteLine("  -> Фабрика підготовлює УКРАЇНСЬКИЙ вантаж...");
            return new UkrainianCargo();
        }
    }
}
