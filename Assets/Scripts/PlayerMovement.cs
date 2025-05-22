using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float sidewaysForce = 100f;
    public float forwardForce = 2000f;
    public float minX;
    public float maxX;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void FixedUpdate()   //  always write physics in unity (eg: velocity, force) in fixedupdate function
    {
        Vector3 playerPos = transform.position;
        if (playerPos.x < minX)
        {
            playerPos.x = minX;
        }

        if (playerPos.x > maxX)
        {
            playerPos.x = maxX;
        }

        transform.position = playerPos;

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);  // add a forward force

        if ( Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + new Vector3(-1*sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
