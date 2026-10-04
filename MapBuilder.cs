using System;

namespace GameMapBuilder
{
    public abstract class MapBuilder
    {
        public event Action<string>? OnStepCompleted;

        protected void LogStep(string message)
        {
            OnStepCompleted?.Invoke(message);
        }

        public abstract void Reset();
        public abstract void BuildTerrain();
        public abstract void BuildEnemies();
        public abstract void BuildItems();
        public abstract void BuildObstacles();
        public abstract void BuildSpawn();
        public abstract GameMap GetMap();
    }
}
