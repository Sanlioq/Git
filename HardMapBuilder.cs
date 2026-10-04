using System.Collections.Generic;

namespace GameMapBuilder
{
    public class HardMapBuilder : MapBuilder
    {
        private GameMap _map = new GameMap();

        public override void Reset()
        {
            _map = new GameMap();
            LogStep("HardMapBuilder: Карту скинуто.");
        }

        public override void BuildTerrain()
        {
            _map.SetTerrain("Лавові поля (Складно)");
            LogStep("HardMapBuilder: Рельєф 'Лавові поля' створено.");
        }

        public override void BuildEnemies()
        {
            _map.SetEnemies(new List<string> { "Вогняний Дракон", "Елітний Орк", "Лавовий Голем" });
            LogStep("HardMapBuilder: Ворогів 'Вогняний Дракон', 'Елітний Орк', 'Лавовий Голем' додано.");
        }

        public override void BuildItems()
        {
            _map.SetItems(new List<string> { "Порожня колба" });
            LogStep("HardMapBuilder: Предмети 'Порожня колба' додано.");
        }

        public override void BuildObstacles()
        {
            _map.SetObstacles(new List<string> { "Лавова яма", "Пастка з шипами", "Зруйнований міст" });
            LogStep("HardMapBuilder: Перешкоди 'Лавова яма', 'Пастка з шипами', 'Зруйнований міст' додано.");
        }

        public override void BuildSpawn()
        {
            _map.SetSpawnPoint("Темна печера (Небезпека)");
            LogStep("HardMapBuilder: Точку спавну 'Темна печера (Небезпека)' встановлено.");
        }

        public override GameMap GetMap()
        {
            LogStep("HardMapBuilder: Карту повернуто.");
            return _map;
        }
    }
}
