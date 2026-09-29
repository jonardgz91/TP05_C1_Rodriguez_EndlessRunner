using UnityEngine;

public class PlayerStarCollide : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbPlayer;
    [SerializeField] private PlayerDataSo player;
    [SerializeField] private AudioClip starClip;
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
            player.lifes += 1;
            audioSource.PlayOneShot(starClip);            
            collision.gameObject.SetActive(false);
        }
    }
}