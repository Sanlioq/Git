using TruckingAbstractFactory.Interfaces;

namespace TruckingAbstractFactory.Ukrainian
{
    public class UkrainianCargo : ICargo
    {
        public string CargoType => "Соняшникова олія";
        public double WeightTons => 19.8;
        public string PackagingType => "Цистерна (харчовий нержавіючий танк)";
        public bool RequiresRefrigeration => false;

        public void PrepareForShipping()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"  [{CargoType}] Підготовка: санітарний сертифікат, фітосанконтроль, митна декларація.");
            Console.ResetColor();
        }

        public void CheckCondition()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"  [{CargoType}] Кислотність: норма. Цистерна чиста. Пломби встановлено.");
            Console.ResetColor();
        }

        public string GetCargoManifest()
        {
            return $"  Вантаж: {CargoType}\n" +
                   $"  Вага: {WeightTons} тонн\n" +
                   $"  Пакування: {PackagingType}\n" +
                   $"  Охолодження: {(RequiresRefrigeration ? "Так" : "Ні")}\n" +
                   $"  Документи: CMR, МД, Сертифікат походження\n" +
                   $"  Маршрут: Дніпро -> Гданськ (Польща)";
        }
    }
}
