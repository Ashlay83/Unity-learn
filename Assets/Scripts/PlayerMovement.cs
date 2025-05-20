using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Game Starts here");
    }

    public Rigidbody Rigidbody;

    // Update is called once per frame
    void Update()
    {
        Rigidbody.AddForce(0,0,1000*Time.deltaTime);
    }
}
