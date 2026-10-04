namespace GameMapBuilder
{
    public class GameMapDirector
    {
        private MapBuilder _builder;

        public GameMapDirector(MapBuilder builder)
        {
            _builder = builder;
        }

        public void SetBuilder(MapBuilder builder)
        {
            _builder = builder;
        }

        public GameMap CreateMap()
        {
            _builder.Reset();
            _builder.BuildTerrain();
            _builder.BuildEnemies();
            _builder.BuildItems();
            _builder.BuildObstacles();
            _builder.BuildSpawn();
            return _builder.GetMap();
        }

        public GameMap CreateEasyMap()
        {
            _builder.Reset();
            _builder.BuildTerrain();
            _builder.BuildItems();
            _builder.BuildSpawn();
            return _builder.GetMap();
        }

        public GameMap CreateHardMap()
        {
            _builder.Reset();
            _builder.BuildTerrain();
            _builder.BuildEnemies();
            _builder.BuildEnemies();
            _builder.BuildObstacles();
            _builder.BuildItems();
            _builder.BuildSpawn();
            return _builder.GetMap();
        }
    }
}
