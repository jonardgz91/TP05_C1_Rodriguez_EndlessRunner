using System;
using UnityEngine;

public class PlayerHeartCollide : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbPlayer;
    [SerializeField] private PlayerDataSo player;
    [SerializeField] private AudioClip starClip;
    private AudioSource audioSource;
    public event Action<int> onLifeUpdate;

    private void Awake()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PowerUp"))
        {
            player.lifes = Math.Clamp(player.lifes + 1, 0, 3);
            audioSource.PlayOneShot(starClip);

            collision.gameObject.SetActive(false);
            onLifeUpdate?.Invoke(player.lifes);
        }
    }
    public void NotifyLifeChanged()
    {
        onLifeUpdate?.Invoke(player.lifes);
    }
}