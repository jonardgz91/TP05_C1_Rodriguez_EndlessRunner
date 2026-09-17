using UnityEngine;

public class PlayerCollide : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbPlayer;
    [SerializeField] private GameObject panelGameOver;
    private bool isOver;

    private void Awake()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (isOver)
        {
            Time.timeScale = 0;
            panelGameOver.SetActive(true);
        }
        else 
        {
            panelGameOver.SetActive(false);
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