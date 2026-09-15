using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private Rigidbody2D rbEnemy;
    private float moveSpeed = 1f;

    private void Awake()
    {
        rbEnemy = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rbEnemy.AddForce(Vector3.left * moveSpeed, ForceMode2D.Force);
    }
}
