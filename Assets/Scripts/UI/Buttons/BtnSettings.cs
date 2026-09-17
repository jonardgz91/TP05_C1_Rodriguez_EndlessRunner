using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BtnSettings : MonoBehaviour
{
    [SerializeField] private Button btnSettings;
    [SerializeField] private GameObject panelPause;
    [SerializeField] private GameObject panelSettings;
    private void Awake()
    {
        btnSettings.onClick.AddListener(SettingsClicked);
    }

    private void OnDestroy()
    {
        btnSettings.onClick.RemoveAllListeners();
    }

    private void SettingsClicked()
    {
        panelPause.SetActive(false);
        panelSettings.SetActive(true);

        if (SceneManager.GetActiveScene().name == "Gameplay")
        {
            Time.timeScale = 0;
        }
    }
}