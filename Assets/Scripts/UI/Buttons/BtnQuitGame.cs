using System;
using UnityEngine;
using UnityEngine.UI;

public class BtnQuitGame : MonoBehaviour
{
    [SerializeField] private Button btnQuitGame;

    private void Awake()
    {
        btnQuitGame.onClick.AddListener(QuitGameClicked);
    }

    private void OnDestroy()
    {
        btnQuitGame.onClick.RemoveAllListeners();
    }

    private void QuitGameClicked()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
