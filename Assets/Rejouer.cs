using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Rejouer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static void lancerPartie()
    {
        
        SceneManager.LoadScene(0);
    }
}
