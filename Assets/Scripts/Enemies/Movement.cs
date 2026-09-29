using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject movingObstacle;
    [SerializeField] private Rigidbody2D rbmovingObstacle;
    public float movingObstacleSpeed = 5f;

    private void Awake()
    {
        rbmovingObstacle = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rbmovingObstacle.linearVelocity = new Vector2(-movingObstacleSpeed, rbmovingObstacle.linearVelocity.y);
    }
}