using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiCredits : MonoBehaviour
{
    [SerializeField] private TMP_Text txtCredits;
    [SerializeField] private Button btnBack;
    [SerializeField] private GameObject panelCredits;
    [SerializeField] private GameObject panelMainMenu;

    private void Awake()
    {
        btnBack.onClick.AddListener(BtnBackClicked);
    }

    private void Start()
    {
        txtCredits.text = "CREDITOS:\n" +
                          "Desarrollado por: Jonathan Rodriguez\n\n" +

                          "PLAYER ASSET:\n" +
                          "## penzilla (penzilla.itch.io)\n\n" +

                          "BACKGROUD, ASSET, SOUNDS, SFX and UI by:\n" +
                          "## Kenney (kenney.nl)\n" +
                          "## Brackeys, Asbjørn Thirslund\n" +
                          "## Chequered Ink (ci.itch.io)\n\n" +

                          "MUSIC by:\n" +
                          "## TallBeard Studios (tallbeard.itch.io)\n" +
                          "## Brackeys (brackeysgames.itch.io)\n\n" +

                          "FONT by:\n" +
                          "## GGBotNet (ggbot.itch.io)\n";
    }

    private void OnDestroy()
    {
        btnBack.onClick.RemoveAllListeners();
    }

    private void BtnBackClicked()
    {
        panelCredits.SetActive(false);
        panelMainMenu.SetActive(true);
    }
}