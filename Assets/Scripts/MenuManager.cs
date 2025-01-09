using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour
{
    
    public static void Jouer()
    {
        SceneManager.LoadScene(1);
    }
    public static void Retour()
    {
        int activeSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(activeSceneIndex - 1);
    }


}
        


         
    

