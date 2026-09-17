using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;
    [SerializeField] private Transform player;
    [SerializeField] private float xOffset = 20f;
    [SerializeField] private float spawnY = -4f;

    private void Start()
    {
        InvokeRepeating(nameof(coinSpawner), 2f, 5f);
    }

    private void coinSpawner()
    {
        Vector2 spawnPosition = new Vector2(player.position.x + xOffset, spawnY);
        GameObject Coin = Instantiate(coin, spawnPosition, Quaternion.identity);
        Destroy(Coin, 4f);
    }
}