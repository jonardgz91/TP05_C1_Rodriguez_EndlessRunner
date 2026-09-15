using UnityEngine;

public class EnemyDestroy : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject LeftLimit;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "LeftLimit")
        {
            transform.position = Vector3.zero;
            enemy.SetActive(false);
        }
    }
}