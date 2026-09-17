using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnStartGame : MonoBehaviour
{
    [SerializeField] private Button btnStartGame;

    private void Awake()
    {
        btnStartGame.onClick.AddListener(StartGameClicked);
    }

    private void OnDestroy()
    {
        btnStartGame.onClick.RemoveAllListeners();
    }

    private void StartGameClicked()
    {
        SceneManager.LoadScene("Gameplay");
    }
}