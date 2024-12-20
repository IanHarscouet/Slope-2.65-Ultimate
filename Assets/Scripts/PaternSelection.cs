using UnityEngine;
using UnityEngine.SceneManagement;

public class PaternSelection : MonoBehaviour
{
    public GameData gameData;
    public static PaternSelection instance;

    public void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("zf");
        }
        instance = this;
    }
    public void SelectionPatern(int index)
    {
        gameData.buttonIndex = index;
        SceneManager.LoadScene(2);
      
    }
}
