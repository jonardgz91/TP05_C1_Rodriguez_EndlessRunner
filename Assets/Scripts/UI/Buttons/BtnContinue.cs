using System;
using UnityEngine;
using UnityEngine.UI;

public class BtnContinue : MonoBehaviour
{
    [SerializeField] private Button btnContinue;

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
        
    }
}
