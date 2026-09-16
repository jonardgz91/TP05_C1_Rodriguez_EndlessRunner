using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private KeyCode pauseGame = KeyCode.Escape;
    [SerializeField] private GameObject pauseCanva;
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(pauseGame))
        {
            isPaused = !isPaused;
            if (isPaused)
            {
                Time.timeScale = 0;
                pauseCanva.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                pauseCanva.SetActive(false);
            }
        }
    }
}
