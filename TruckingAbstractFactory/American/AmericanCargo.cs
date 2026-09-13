using TruckingAbstractFactory.Interfaces;

namespace TruckingAbstractFactory.American
{
    public class AmericanCargo : ICargo
    {
        public string CargoType => "Зерно кукурудзи";
        public double WeightTons => 22.0;
        public string PackagingType => "Насипний (bulk grain trailer)";
        public bool RequiresRefrigeration => false;

        public void PrepareForShipping()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"  [{CargoType}] Підготовка: зважування, Bill of Lading, USDA сертифікат.");
            Console.ResetColor();
        }

        public void CheckCondition()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"  [{CargoType}] Вологість: 14%. Відсутність сторонніх домішок. Approved!");
            Console.ResetColor();
        }

        public string GetCargoManifest()
        {
            return $"  Вантаж: {CargoType}\n" +
                   $"  Вага: {WeightTons} тонн\n" +
                   $"  Пакування: {PackagingType}\n" +
                   $"  Охолодження: {(RequiresRefrigeration ? "Так" : "Ні")}\n" +
                   $"  Документи: Bill of Lading, USDA Cert\n" +
                   $"  Маршрут: Канзас -> Новий Орлеан";
        }
    }
}
