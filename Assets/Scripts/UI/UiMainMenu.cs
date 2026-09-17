using UnityEngine;

public class UiMainMenu : MonoBehaviour
{
    [SerializeField] private GameObject panelSettings;
    private void Start()
    {
        panelSettings.SetActive(false);
    }
}