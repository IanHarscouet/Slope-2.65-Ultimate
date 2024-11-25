using UnityEngine;

public class CubeTrigger : MonoBehaviour
{
    private Obstacle_Manager obstacle_manager;
    public GameObject finObstacle;
    public GameObject débutObstacle;

    public void Awake()
    {
       obstacle_manager = GameObject.Find("Obstacle Manager").GetComponent<Obstacle_Manager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {          
            obstacle_manager.CreationPrefab(finObstacle.transform.position/*,débutObstacle.transform.position*/);
        }
    }
}
