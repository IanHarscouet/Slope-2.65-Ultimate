using UnityEngine;

public class TutorialGoal : MonoBehaviour
{
    private GameObject Player;
    public GameObject gameManager;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameManager.GetComponent<TutorielScript>().EndTutoriel();
        }
    }
}
