using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnMainMenu : MonoBehaviour
{
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
        SceneManager.LoadScene("MainMenu");
    }
}