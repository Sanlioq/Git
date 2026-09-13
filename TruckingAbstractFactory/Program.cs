using TruckingAbstractFactory.American;
using TruckingAbstractFactory.Client;
using TruckingAbstractFactory.European;
using TruckingAbstractFactory.Interfaces;
using TruckingAbstractFactory.Ukrainian;

Console.OutputEncoding = System.Text.Encoding.UTF8;

PrintHeader();

RunDemo(
    factory: new EuropeanTruckingFactory(),
    from: "Мюнхен (Германія)",
    to: "Варшава (Польща)",
    color: ConsoleColor.Blue
);

RunDemo(
    factory: new AmericanTruckingFactory(),
    from: "Канзас-Сіті (США)",
    to: "Новий Орлеан (США)",
    color: ConsoleColor.Red
);

RunDemo(
    factory: new UkrainianTruckingFactory(),
    from: "Дніпро (Україна)",
    to: "Гданськ (Польща)",
    color: ConsoleColor.Yellow
);

PrintFooter();

static void RunDemo(ITruckingFactory factory, string from, string to, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine();
    Console.WriteLine($"╔══════════════════════════════════════════════════════════════════════╗");
    Console.WriteLine($"║  КОМПАНІЯ: {factory.CompanyName,-58}║");
    Console.WriteLine($"║  РЕГІОН:   {factory.Region,-58}║");
    Console.WriteLine($"╚══════════════════════════════════════════════════════════════════════╝");
    Console.ResetColor();

    Console.WriteLine();
    Console.WriteLine("  [Клієнт] Ініціалізація TripDispatcher з фабрикою: " + factory.CompanyName);

    var dispatcher = new TripDispatcher(factory);
    dispatcher.OrganizeTrip(from, to);
}

static void PrintHeader()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine();
    Console.WriteLine("  ======================================================================");
    Console.WriteLine("   ПАТЕРН: АБСТРАКТНА ФАБРИКА  |  Тема: Система дальнобійників");
    Console.WriteLine("   Варіант 6  |  3 Фабрики x 3 Продукти = 9 конкретних класів");
    Console.WriteLine("  ======================================================================");
    Console.ResetColor();
}

static void PrintFooter()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine();
    Console.WriteLine("  ======================================================================");
    Console.WriteLine("   ВСІ 3 ФАБРИКИ ВИКОНАЛИ РЕЙСИ УСПІШНО!");
    Console.WriteLine();
    Console.WriteLine("   ПІДСУМОК ПАТЕРНУ «Абстрактна Фабрика»:");
    Console.WriteLine("  • Клієнт (TripDispatcher) НЕ знає про конкретні класи продуктів");
    Console.WriteLine("  • Зміна фабрики = зміна всього сімейства об'єктів одним рядком");
    Console.WriteLine("  • Гарантується сумісність: EU-Truck завжди з EU-Driver і EU-Cargo");
    Console.WriteLine("  • Легко додати Фабрику #4 без зміни клієнтського коду");
    Console.WriteLine("  ======================================================================");
    Console.ResetColor();
    Console.WriteLine();
}
