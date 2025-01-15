using TMPro;
using UnityEngine;

public class TutorielScript : MonoBehaviour
{
    public Canvas ecranDebutTutoriel;
    public TextMeshPro InGameInstruction;
    public Canvas ecranFinTutoriel;
    void Start()
    {
        Time.timeScale = 0;
        ecranDebutTutoriel.enabled = true;
        
    }
    
    public void LancerTutoriel()
    {
        ecranDebutTutoriel.enabled=false;
        InGameInstruction.enabled = true;
        Time.timeScale = 1;

    }
    public void EndTutoriel()
    {
        Time.timeScale = 0;
        ecranFinTutoriel.enabled= true;

    }
}
