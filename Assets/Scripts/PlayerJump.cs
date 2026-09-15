using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private PlayerDataSo player;
    [SerializeField] private Rigidbody2D rbPlayer;
    public float jumpForce = 5f;
    private bool isFloor;

    private void Awake()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (isFloor && Input.GetKeyDown(player.jump))
        {
            rbPlayer.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
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