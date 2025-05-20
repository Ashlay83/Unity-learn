using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //Start is called once before the first execution of Update after the MonoBehaviour is created
    public PlayerMovement movement;
     void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            Debug.Log("You have hit an obstacle!");
            movement.enabled = false;
        }
    }
}
