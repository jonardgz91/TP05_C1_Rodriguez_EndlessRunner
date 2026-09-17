using UnityEngine;
using UnityEngine.Rendering;

public class PlayerCollide : MonoBehaviour
{
    [SerializeField] private PlayerDataSo player;
    [SerializeField] private Rigidbody2D rbPlayer;
    [SerializeField] private GameObject panelGameOver;
    [SerializeField] private AudioClip loseClip;
    [SerializeField] private AudioSource backgroudMusic;
    private AudioSource audioSource;

    private void Awake()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(player.isOver)
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
            player.isOver = true;
            backgroudMusic.Stop();
            audioSource.PlayOneShot(loseClip);
        }
    }
}