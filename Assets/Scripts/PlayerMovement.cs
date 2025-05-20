using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Game Starts here");
    }

    public Rigidbody Rigidbody;
    public float ForwardForce=500f;
    public float SideForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody.AddForce(0,0,ForwardForce*Time.deltaTime,0);

        if (Input.GetKey("d"))
        {
            Rigidbody.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            Rigidbody.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }



    }
}
