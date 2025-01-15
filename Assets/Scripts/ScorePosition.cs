using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ScorePosition : MonoBehaviour
{
    // les différent score sont sensé bouger quand le score dépasse un certain seuil mais pas encore au point
    public float vitesse;
    public TextMeshProUGUI affichageScore;
    public bool deplacementFini = true;
    public Vector2 affichageScoreTargetPosition;
    public float rotationspeed;

    public void Awake()
    {
        float sens = Random.Range(0,2) == 0 ? 1 : -1;
        rotationspeed = Random.Range(30, 60)* sens;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UIMovement();
        affichageScore.rectTransform.rotation *= Quaternion.Euler(0, 0, rotationspeed*Time.fixedDeltaTime);

    }

public void UIMovement()
    {
        if (deplacementFini) 
        {
            affichageScoreTargetPosition = new Vector2(Random.Range(-480, 480), Random.Range(-328, 328));            
            if (vitesse < 100)
            {
                vitesse+= 5;
            }
            deplacementFini = false;
        }
        else
        {
            affichageScore.rectTransform.anchoredPosition = Vector2.MoveTowards(affichageScore.rectTransform.anchoredPosition, affichageScoreTargetPosition, vitesse * Time.fixedDeltaTime);            
            if (affichageScoreTargetPosition == affichageScore.rectTransform.anchoredPosition)
            {
                deplacementFini=true;
            }
            
        }
       
    }
}
