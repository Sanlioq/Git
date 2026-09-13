using TruckingAbstractFactory.Interfaces;

namespace TruckingAbstractFactory.European
{
    public class EuropeanTruckingFactory : ITruckingFactory
    {
        public string CompanyName => "EuroFreight GmbH";
        public string Region => "Євросоюз";

        public ITruck CreateTruck()
        {
            Console.WriteLine("  -> Фабрика створює ЄВРОПЕЙСЬКУ вантажівку...");
            return new EuropeanTruck();
        }

        public IDriver CreateDriver()
        {
            Console.WriteLine("  -> Фабрика наймає ЄВРОПЕЙСЬКОГО водія...");
            return new EuropeanDriver();
        }

        public ICargo CreateCargo()
        {
            Console.WriteLine("  -> Фабрика підготовлює ЄВРОПЕЙСЬКИЙ вантаж...");
            return new EuropeanCargo();
        }
    }
}
