using UnityEngine;

public class PlayerCoinCollide : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbPlayer;
    [SerializeField] private PlayerDataSo player;
    [SerializeField] private GameObject coin;

    private void Awake()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            player.score += 10;
            coin.SetActive(false);
        }
    }
}