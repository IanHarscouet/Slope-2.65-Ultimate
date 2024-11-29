using UnityEngine;

public class Accelerateur : MonoBehaviour
{
    public PlayerController controller;
    public float CoeffAcceleration;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            controller = other.GetComponent<PlayerController>();            
            controller.rb.linearVelocity = new Vector3(CoeffAcceleration* controller.rb.linearVelocity.x, controller.rb.linearVelocity.y, controller.rb.linearVelocity.z);
                
        }
    }
}
