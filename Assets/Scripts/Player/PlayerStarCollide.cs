using UnityEngine;

public class PlayerStarCollide : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbPlayer;
    [SerializeField] private PlayerDataSo player;
    [SerializeField] private AudioClip starClip;
    [SerializeField] private float powerUpDuration = 10.0f;
    private AudioSource audioSource;

    private void Awake()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PowerUp"))
        {
            player.jumpForce *= 1.3f;
            audioSource.PlayOneShot(starClip);            
            collision.gameObject.SetActive(false);
            Invoke(nameof(ResetJumpForce), powerUpDuration);
        }
    }

    private void ResetJumpForce()
    {
        player.jumpForce /= 1.3f;
    }
}