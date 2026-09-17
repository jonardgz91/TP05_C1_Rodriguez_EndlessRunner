using UnityEngine;
using UnityEngine.UI;

public class BtnCredits : MonoBehaviour
{
    [SerializeField] private Button btnCredits;
    [SerializeField] private GameObject panelMainMenu;
    [SerializeField] private GameObject panelCredits;

    private void Awake()
    {
        btnCredits.onClick.AddListener(CreditsClicked);
    }

    private void OnDestroy()
    {
        btnCredits.onClick.RemoveAllListeners();
    }

    private void CreditsClicked()
    {
        panelMainMenu.SetActive(false);
        panelCredits.SetActive(true);
    }
}