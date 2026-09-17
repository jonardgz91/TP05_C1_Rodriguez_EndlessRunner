using UnityEngine;

public class UiMainMenu : MonoBehaviour
{
    [SerializeField] private GameObject panelSettings;
    [SerializeField] private GameObject panelCredits;

    private void Start()
    {
        panelSettings.SetActive(false);
        panelCredits.SetActive(false);
    }
}