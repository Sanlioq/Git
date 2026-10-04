using System.Collections.Generic;

namespace GameMapBuilder
{
    public class EasyMapBuilder : MapBuilder
    {
        private GameMap _map = new GameMap();

        public override void Reset()
        {
            _map = new GameMap();
            LogStep("EasyMapBuilder: Карту скинуто.");
        }

        public override void BuildTerrain()
        {
            _map.SetTerrain("Зелені луки (Легко)");
            LogStep("EasyMapBuilder: Рельєф 'Зелені луки' створено.");
        }

        public override void BuildEnemies()
        {
            _map.SetEnemies(new List<string> { "Слизень", "Слабкий Гоблін" });
            LogStep("EasyMapBuilder: Ворогів 'Слизень', 'Слабкий Гоблін' додано.");
        }

        public override void BuildItems()
        {
            _map.SetItems(new List<string> { "Зілля здоров'я", "Мапа", "Золоті монети" });
            LogStep("EasyMapBuilder: Предмети 'Зілля здоров'я', 'Мапа', 'Золоті монети' додано.");
        }

        public override void BuildObstacles()
        {
            _map.SetObstacles(new List<string> { "Невеликий камінь" });
            LogStep("EasyMapBuilder: Перешкоди 'Невеликий камінь' додано.");
        }

        public override void BuildSpawn()
        {
            _map.SetSpawnPoint("Безпечне село");
            LogStep("EasyMapBuilder: Точку спавну 'Безпечне село' встановлено.");
        }

        public override GameMap GetMap()
        {
            LogStep("EasyMapBuilder: Карту повернуто.");
            return _map;
        }
    }
}
