using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;
    [SerializeField] private Transform player;
    [SerializeField] private float xOffset = 24f;
    [SerializeField] private float spawnY = -2.0f;

    private void Start()
    {
        InvokeRepeating(nameof(coinSpawner), 2f, 10f);
    }

    private void coinSpawner()
    {
        Vector2 spawnPosition = new Vector2(player.position.x + xOffset, spawnY);
        GameObject Coin = Instantiate(coin, spawnPosition, Quaternion.identity);
        Destroy(Coin, 20f);
    }
}