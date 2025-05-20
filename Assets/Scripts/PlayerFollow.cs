
using JetBrains.Annotations;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public Transform player;
    public Vector3 offset;             
    void Update()
    {
        transform.position = player.position + offset;
    }
}
