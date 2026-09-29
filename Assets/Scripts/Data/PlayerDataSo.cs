using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Data/Game/PlayerData")]

public class PlayerDataSo : ScriptableObject
{
    public KeyCode jump;
    public int lifes = 1;
    public float jumpForce = 6f;
    public float score = 0;
    public bool isOver = false;
}