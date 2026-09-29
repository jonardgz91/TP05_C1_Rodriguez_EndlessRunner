using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnObject;
    [SerializeField] private float xLimit = -10f;
    [SerializeField] private float xIncitial = 10f;
    [SerializeField] private float spawnY = -4;
    [SerializeField] private float time = 3f;
    [SerializeField] private float repeatRate = 8f;
    public float spawnObjectSpeed = 5f;

    private List<Transform> activeObjects = new List<Transform>();

    private void Start()
    {
        InvokeRepeating(nameof(Spawn), time, repeatRate);
    }

    private void Update()
    {
        for (int i = activeObjects.Count - 1; i >= 0; i--)
        {
            Transform enemy = activeObjects[i];
            enemy.position += Vector3.left * (spawnObjectSpeed * Time.deltaTime);

            if (enemy.position.x <= xLimit)
            {
                activeObjects.RemoveAt(i);
                Destroy(enemy.gameObject);
            }
        }
    }

    private void Spawn()
    {
        Vector2 spawnPosition = new Vector2(xIncitial, spawnY);
        GameObject Tree = Instantiate(spawnObject, spawnPosition, Quaternion.identity);
        Destroy(Tree, 4f);
    }
}