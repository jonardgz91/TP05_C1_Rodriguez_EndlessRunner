using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    [SerializeField] private PlayerDataSo player;
    private void Update()
    {
        player.score += Time.deltaTime;
    }
}