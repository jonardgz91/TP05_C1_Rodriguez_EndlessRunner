using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyTree;
    [SerializeField] private Transform player;
    [SerializeField] private float xOffset = 20f;
    [SerializeField] private float spawnY = -4f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 3f, 8f);
    }

    private void SpawnEnemy()
    {
        Vector2 spawnPosition = new Vector2(player.position.x + xOffset, spawnY);
        GameObject Tree = Instantiate(enemyTree, spawnPosition, Quaternion.identity);
        Destroy(Tree, 4f);
    }
}