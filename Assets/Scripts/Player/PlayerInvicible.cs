using UnityEngine;
using UnityEngine.Audio;

public class PlayerInvicible : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbPlayer;
    [SerializeField] private PlayerDataSo player;
    private float timer = 5.0f;

    private void Awake()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        //audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Invincible"))
        {
            timer -= Time.deltaTime;
        }
    }
}