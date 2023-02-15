using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sideWayForce = 200f;
    public float jumpForce = 1f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0,forwardForce * Time.deltaTime) ;
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideWayForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWayForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            //rb.AddForce(0, jumpForce, 0);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().endGame();
        }
    }
    
        
    
}
