using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnTryAgain : MonoBehaviour
{
    [SerializeField] private Button btnTryAgain;
    [SerializeField] private PlayerDataSo player;

    private void Awake()
    {
        btnTryAgain.onClick.AddListener(TryAgainClicked);
    }

    private void OnDestroy()
    {
        btnTryAgain.onClick.RemoveAllListeners();
    }

    private void TryAgainClicked()
    {
        player.isOver = false;
        Time.timeScale = 1;
        player.score = 0;
        player.jumpForce = 5f;
        SceneManager.LoadScene("Gameplay");
    }
}