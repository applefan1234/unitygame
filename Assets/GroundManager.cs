// GroundManager.cs
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    public GameObject[] groundPrefabs; // Array to hold different ground prefabs
    public float spawnInterval = 2f;
    private float nextSpawnTime = 0f;
    public Transform playerTransform;

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
        // Choose a random index for the groundPrefabs array
        int randomIndex = Random.Range(0, groundPrefabs.Length);

        // Get the selected prefab
        GameObject selectedPrefab = groundPrefabs[randomIndex];

        // Spawn ground relative to the player's position
        Vector2 spawnPosition = new Vector2(playerTransform.position.x + 15, transform.position.y);
        Instantiate(selectedPrefab, spawnPosition, Quaternion.identity);
    }
}
