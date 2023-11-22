// ObstacleManager.cs
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 3f;
    private float nextSpawnTime = 0f;

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnObstacle();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    void SpawnObstacle()
    {
        float randomX = Random.Range(-5f, 5f);
        Instantiate(obstaclePrefab, new Vector2(randomX, transform.position.y), Quaternion.identity);
    }
}
