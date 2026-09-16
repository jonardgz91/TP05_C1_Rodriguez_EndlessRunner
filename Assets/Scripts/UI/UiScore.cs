using TMPro;
using UnityEngine;

public class UiScore : MonoBehaviour
{
    [SerializeField] private PlayerDataSo player;
    [SerializeField] private TMP_Text textPlayerScore;

    private void Update()
    {
        textPlayerScore.text = player.score.ToString("F0");
    }
}
