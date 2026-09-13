using TruckingAbstractFactory.Interfaces;

namespace TruckingAbstractFactory.American
{
    public class AmericanTruckingFactory : ITruckingFactory
    {
        public string CompanyName => "BigRig Logistics LLC";
        public string Region => "США / Північна Америка";

        public ITruck CreateTruck()
        {
            Console.WriteLine("  -> Фабрика створює АМЕРИКАНСЬКУ вантажівку...");
            return new AmericanTruck();
        }

        public IDriver CreateDriver()
        {
            Console.WriteLine("  -> Фабрика наймає АМЕРИКАНСЬКОГО водія...");
            return new AmericanDriver();
        }

        public ICargo CreateCargo()
        {
            Console.WriteLine("  -> Фабрика підготовлює АМЕРИКАНСЬКИЙ вантаж...");
            return new AmericanCargo();
        }
    }
}
