using TruckingAbstractFactory.Interfaces;

namespace TruckingAbstractFactory.European
{
    public class EuropeanCargo : ICargo
    {
        public string CargoType => "Автомобілі BMW";
        public double WeightTons => 18.5;
        public string PackagingType => "Автовоз (відкритий транспорт)";
        public bool RequiresRefrigeration => false;

        public void PrepareForShipping()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"  [{CargoType}] Підготовка: перевірка кріплень, захист кузова, CMR накладна.");
            Console.ResetColor();
        }

        public void CheckCondition()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"  [{CargoType}] Стан: відмінний. Автомобілі зафіксовані стропами. VIN перевірено.");
            Console.ResetColor();
        }

        public string GetCargoManifest()
        {
            return $"  Вантаж: {CargoType}\n" +
                   $"  Вага: {WeightTons} тонн\n" +
                   $"  Пакування: {PackagingType}\n" +
                   $"  Охолодження: {(RequiresRefrigeration ? "Так" : "Ні")}\n" +
                   $"  Документи: CMR, EUR.1, TIR Carnet\n" +
                   $"  Маршрут: Мюнхен -> Варшава";
        }
    }
}
