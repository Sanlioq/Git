using TruckingAbstractFactory.Interfaces;

namespace TruckingAbstractFactory.Client
{
    public class TripDispatcher
    {
        private readonly ITruck _truck;
        private readonly IDriver _driver;
        private readonly ICargo _cargo;
        private readonly string _companyName;

        public TripDispatcher(ITruckingFactory factory)
        {
            _companyName = factory.CompanyName;
            _truck = factory.CreateTruck();
            _driver = factory.CreateDriver();
            _cargo = factory.CreateCargo();
        }

        public void OrganizeTrip(string departureCity, string destinationCity)
        {
            Console.WriteLine();
            Console.WriteLine("  ==========================================");
            Console.WriteLine("  ТЕХНІЧНІ ХАРАКТЕРИСТИКИ РЕЙСУ");
            Console.WriteLine("  ==========================================");
            Console.WriteLine(_truck.GetSpecifications());
            Console.WriteLine();
            Console.WriteLine(_driver.GetDriverInfo());
            Console.WriteLine();
            Console.WriteLine(_cargo.GetCargoManifest());
            Console.WriteLine();
            Console.WriteLine("  ==========================================");
            Console.WriteLine("  ВИКОНАННЯ РЕЙСУ");
            Console.WriteLine("  ==========================================");
            _cargo.PrepareForShipping();
            _cargo.CheckCondition();
            _truck.StartEngine();
            _truck.LoadCargo(_cargo.CargoType);
            _driver.DriveRoute(departureCity, destinationCity);
            _driver.RestAtStop();
            Console.WriteLine();
            Console.WriteLine($"  Рейс компанії '{_companyName}' успішно завершено!");
            Console.WriteLine($"  {departureCity} -> {destinationCity} | Вантаж: {_cargo.CargoType}");
        }
    }
}
