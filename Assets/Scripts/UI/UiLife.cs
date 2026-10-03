using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiLife : MonoBehaviour
{
    [SerializeField] private List<Image> images = new List<Image>();
    [SerializeField] private PlayerHeartCollide PlayerHeartCollide;

    private void Awake()
    {
        PlayerHeartCollide.onLifeUpdate += UpdateLifes;
    }

    private void OnDestroy()
    {
        PlayerHeartCollide.onLifeUpdate -= UpdateLifes;
    }

    private void UpdateLifes(int currentLife)
    {
        for (int i = 0; i < images.Count; i++)
        {
            images[i].gameObject.SetActive(i < currentLife);
        }
    }
}
