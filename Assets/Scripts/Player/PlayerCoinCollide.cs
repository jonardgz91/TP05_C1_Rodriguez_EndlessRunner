using UnityEngine;

public class PlayerCoinCollide : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbPlayer;
    [SerializeField] private PlayerDataSo player;
    [SerializeField] private AudioClip coinClip;
    private AudioSource audioSource;

    private void Awake()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            player.score += 10;
            audioSource.PlayOneShot(coinClip);
            collision.gameObject.SetActive(false);
        }
    }
}