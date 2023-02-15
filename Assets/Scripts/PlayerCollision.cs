
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.tag == "Enemy")
        {
            Debug.Log(collision.collider.name);
            movement.enabled = false;
            FindObjectOfType<GameManager>().endGame();
           //Destroy(gameObject);
        }
    }
}
