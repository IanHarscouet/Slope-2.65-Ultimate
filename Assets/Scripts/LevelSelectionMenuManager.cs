using UnityEngine;
using UnityEngine.UI;

public class LevelSelectionMenuManager : MonoBehaviour
{
    public Canvas LevelSelectionBaseCanvas;
    public Canvas LevelSelectionGuide;    
    
    public void LevelSelectionCanvasGuideEnabled()
    {
        LevelSelectionGuide.enabled = true;
        LevelSelectionBaseCanvas.enabled = false;        
    }
    public void LevelSelectionCanvasGuideDisabled()
    {
        LevelSelectionBaseCanvas.enabled = true;
        LevelSelectionGuide.enabled = false;        

    }
    

}
