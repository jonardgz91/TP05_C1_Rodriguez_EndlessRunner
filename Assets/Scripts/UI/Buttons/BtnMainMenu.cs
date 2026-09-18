using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnMainMenu : MonoBehaviour
{
    [SerializeField] private PlayerDataSo player;
    [SerializeField] private Button btnMainMenu;

    private void Awake()
    {
        btnMainMenu.onClick.AddListener(MainMenuClicked);
    }

    private void OnDestroy()
    {
        btnMainMenu.onClick.RemoveAllListeners();
    }

    private void MainMenuClicked()
    {
        player.isOver = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}