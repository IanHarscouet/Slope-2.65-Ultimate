using TMPro;
using UnityEngine;

public class ObstacleDestroyPlayer : MonoBehaviour
{
    private GameObject Player;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
           other.gameObject.GetComponent<PlayerController>().OnPlayerDeath();            
        }
    }
    
}
