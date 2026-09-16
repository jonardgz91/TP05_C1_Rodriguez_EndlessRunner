using UnityEngine;

public class PlayerCollide : MonoBehaviour
{
    [SerializeField] private PlayerDataSo player;
    [SerializeField] private Rigidbody2D rbPlayer;
    [SerializeField] private GameObject pauseCanva;
    private bool isOver;

    private void Awake()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isOver)
        {
            Time.timeScale = 0;
            pauseCanva.SetActive(true);
        }
        else 
        {
            pauseCanva.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyGreenCube"))
        {
            isOver = true;
        }
    }
}