public class BombSpawner : Spawner
{
    private void Reset()
    {
        this.prefabName = "BombPrefab";
        this.spawnPosName = "BombSpawnPos";
        this.layerOrder = 1;
        this.maxObj = 7;
    }
}
