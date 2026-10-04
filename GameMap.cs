using System.Collections.Generic;
using System.Text;

namespace GameMapBuilder
{
    public class GameMap
    {
        private string terrain = "";
        private List<string> enemies = new List<string>();
        private List<string> items = new List<string>();
        private List<string> obstacles = new List<string>();
        private string spawnPoint = "";

        public void SetTerrain(string t) { terrain = t; }
        public void SetEnemies(List<string> e) { enemies = e; }
        public void SetItems(List<string> i) { items = i; }
        public void SetObstacles(List<string> o) { obstacles = o; }
        public void SetSpawnPoint(string s) { spawnPoint = s; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Рельєф: {terrain}");
            sb.AppendLine($"Точка спавну: {spawnPoint}");
            sb.AppendLine($"Вороги: {(enemies.Count > 0 ? string.Join(", ", enemies) : "Немає")}");
            sb.AppendLine($"Предмети: {(items.Count > 0 ? string.Join(", ", items) : "Немає")}");
            sb.AppendLine($"Перешкоди: {(obstacles.Count > 0 ? string.Join(", ", obstacles) : "Немає")}");
            return sb.ToString();
        }
    }
}
