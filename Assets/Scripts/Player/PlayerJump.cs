using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private PlayerDataSo player;
    [SerializeField] private Rigidbody2D rbPlayer;
    [SerializeField] private Animator animator;
    private bool isFloor;

    private void Awake()
    {
        if (player == null)
        {
            rbPlayer = GetComponent<Rigidbody2D>();
        }
    }

    private void Update()
    {
        if (isFloor && Input.GetKeyDown(player.jump))
        {
            rbPlayer.AddForce(Vector2.up * player.jumpForce, ForceMode2D.Impulse);
            animator.SetTrigger("WasJump");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            isFloor = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            isFloor = false;
        }
    }
}