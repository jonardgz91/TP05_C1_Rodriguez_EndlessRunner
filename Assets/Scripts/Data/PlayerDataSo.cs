using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Data/Game/PlayerData")]

public class PlayerDataSo : ScriptableObject
{
    public KeyCode jump;
    public float jumpForce = 5f;
    public float initialSpeed = 5f;
    public float score = 0;
    public bool isOver = false;
}