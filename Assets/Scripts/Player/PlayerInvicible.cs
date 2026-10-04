using UnityEngine;
using UnityEngine.Audio;

public class PlayerInvicible : MonoBehaviour
{
    [SerializeField] private Collider2D enemyCollider;
    [SerializeField] private PlayerDataSo player;
    private float timer = 5.0f;
    private bool isInvincible = false;

    private void Awake()
    {
        //audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (isInvincible)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                enemyCollider.enabled = true;
                isInvincible = false;
                timer = 5.0f;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Invincible"))
        {
            isInvincible = true;
            enemyCollider.enabled = false;

            collision.gameObject.SetActive(false);
        }
    }
}