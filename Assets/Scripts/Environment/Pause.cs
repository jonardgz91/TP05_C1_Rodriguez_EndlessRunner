using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private KeyCode pauseGame = KeyCode.Escape;
    [SerializeField] private GameObject panelPause;
    private bool isPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(pauseGame))
        {
            isPaused = !isPaused;
            if (isPaused)
            {
                Time.timeScale = 0;
                panelPause.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                panelPause.SetActive(false);
            }
        }
    }
}