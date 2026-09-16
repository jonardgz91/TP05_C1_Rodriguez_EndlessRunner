using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    [SerializeField] private PlayerDataSo player;

    void Update()
    {
        player.score += Time.deltaTime;
    }
}