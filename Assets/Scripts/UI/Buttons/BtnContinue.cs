using UnityEngine;
using UnityEngine.UI;

public class BtnContinue : MonoBehaviour
{
    [SerializeField] private Button btnContinue;
    [SerializeField] private GameObject panelPause;

    private void Awake()
    {
        btnContinue.onClick.AddListener(ContinueClicked);
    }

    private void OnDestroy()
    {
        btnContinue.onClick.RemoveAllListeners();
    }

    private void ContinueClicked()
    {
        panelPause.SetActive(false);
        Time.timeScale = 1;
    }
}