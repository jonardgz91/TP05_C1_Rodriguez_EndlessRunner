using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    [SerializeField] private Transform player;
    [SerializeField] private List<Transform> sprites = new List<Transform>();

    private void Update()
    {
        for (int i = 0; i < sprites.Count; i++)
        {
            sprites[i].position += Vector3.left * (speed * Time.deltaTime);
        }

        if (sprites[0].transform.position.x < -19.0f)
        {
            Transform current = sprites[0];
            Transform target = sprites[^1];

            sprites.Remove(current);
            sprites.Add(current);

            float posX = target.position.x;
            float scaleX = 19f;
            current.localPosition = new Vector3(posX + scaleX + 0f, 0f);
        }
    }
}