using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private KeyCode pauseGame = KeyCode.Escape;
    private bool isPaused = false;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(pauseGame))
        {
            isPaused = !isPaused;
            if (isPaused)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
    }
}
