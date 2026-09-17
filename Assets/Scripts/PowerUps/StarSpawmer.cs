using UnityEngine;

public class StarSpawner : MonoBehaviour
{
    public GameObject star;
    [SerializeField] private Transform player;
    [SerializeField] private float xOffset = 32f;
    [SerializeField] private float spawnY = -2.0f;

    private void Start()
    {
        InvokeRepeating(nameof(coinSpawner), 5f, 20f);
    }

    private void coinSpawner()
    {
        Vector2 spawnPosition = new Vector2(player.position.x + xOffset, spawnY);
        GameObject Star = Instantiate(star, spawnPosition, Quaternion.identity);
        Destroy(Star, 5f);
    }
}
