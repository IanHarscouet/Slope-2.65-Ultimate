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
            controller.Speed *= CoeffAcceleration ;
        }
    }
}
