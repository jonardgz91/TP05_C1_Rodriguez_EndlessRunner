using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbPlayer;
    [SerializeField] private float moveSpeed = 1f;

    private void Awake()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rbPlayer.linearVelocity = new Vector2(moveSpeed, rbPlayer.linearVelocity.y); 
    }
}