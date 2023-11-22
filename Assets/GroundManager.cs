// GroundManager.cs
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    public GameObject groundPrefab;
    public float spawnInterval = 2f;
    private float nextSpawnTime = 0f;
    private Transform playerTransform;

    void Start()
    {
        // Find the player by tag
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            playerTransform = player.transform;
        }
        else
        {
            Debug.LogError("Player not found. Make sure the player has the 'Player' tag.");
        }
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnGround();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    void SpawnGround()
    {
        // Spawn ground relative to the player's position
        Vector2 spawnPosition = new Vector2(playerTransform.position.x+15, transform.position.y);
        Instantiate(groundPrefab, spawnPosition, Quaternion.identity);
    }
}
