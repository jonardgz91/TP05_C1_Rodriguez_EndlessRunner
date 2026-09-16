using UnityEngine;

public class UiHidder : MonoBehaviour
{
    [SerializeField] private GameObject panelSettings;
    [SerializeField] private GameObject panelPause;
    void Start()
    {
        panelSettings.SetActive(false);
        panelPause.SetActive(false);
    }
}