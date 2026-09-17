using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnBackSettings : MonoBehaviour
{
    [SerializeField] private Button btnBackSettings;
    [SerializeField] private GameObject panelPause;
    [SerializeField] private GameObject panelSettings;

    private void Awake()
    {
        btnBackSettings.onClick.AddListener(BackSettingsClicked);
    }

    private void OnDestroy()
    {
        btnBackSettings.onClick.AddListener(BackSettingsClicked);
    }

    private void BackSettingsClicked()
    {
        if (SceneManager.GetActiveScene().name == "Gameplay")
        {
            panelSettings.SetActive(false);
            panelPause.SetActive(true);
        }

        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            panelSettings.SetActive(false);
            panelPause.SetActive(true);
        }
    }
}