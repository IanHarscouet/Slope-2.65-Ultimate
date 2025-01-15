using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;


public class PlayerController : MonoBehaviour
{    
    public float Movement;
    public Rigidbody rb;
    public float Speed;
    public float SpeedGoalForward;
    public float ForwardAcceleration;

    
    public float HorizontalMoveSpeed;
    public float debugVelocity;
    
    public GameObject DeathCheck;
    public float CoeffGravity;
    public MeshRenderer mr;

    public Canvas ecranfin;
    public Canvas ScoreUI;
    public TextMeshProUGUI AffichageScore;
    public TextMeshProUGUI AffichageScoreDore;
    public TextMeshProUGUI AffichageScoreRouge;
    public TextMeshProUGUI AffichageScoreFinalNoir;
    public TextMeshProUGUI AffichageScoreFinalDore;
    public TextMeshProUGUI AffichageScoreFinalRouge;
    public float Score =1;
    public float ScoreDore = 1;
    public float ScoreRouge = 1;
    public bool isAlive;

    
    


    public void Start()
    {
          
        isAlive = true;        
        if( SceneManager.GetActiveScene().buildIndex != 3)
        {
            // utile quand on relance une partie depuis l'écran de défaite
            Time.timeScale = 1;
        }
         
        Score = transform.position.x;
        Physics.gravity = Vector3.down * 9 * CoeffGravity;
    }   
    void Update()
    {
        if (isAlive)
        {
            debugVelocity = rb.linearVelocity.x;
            Movement = Input.GetAxisRaw("Horizontal");
            Score = Mathf.Abs(transform.position.x);
            Score = Mathf.Floor(Mathf.Exp(0.01f * Score));
            if (Score > 10000000)
            {
                Score = Random.Range(1000000, 10000000 - 1);
                ScoreDore++;
            }
            AffichageScore.text = Score.ToString();
            float ScoreDoreExp = (Mathf.Floor(Mathf.Exp(0.005f * ScoreDore)));
            if (ScoreDoreExp > 10000000)
            {
                ScoreDoreExp = Random.Range(1000000, 10000000 - 1);
                ScoreRouge++;

            }
            AffichageScoreDore.text = ScoreDoreExp.ToString();
            AffichageScore.text = Score.ToString();
            AffichageScoreRouge.text = Mathf.Floor(Mathf.Exp(0.001f * ScoreRouge)).ToString();
            if (rb.transform.position.y <= DeathCheck.transform.position.y)
            {
                OnPlayerDeath();
            }
        }
    }
    private void FixedUpdate()
    {
        float friction = Mathf.Pow(0.3f,Time.fixedDeltaTime);        
        rb.linearVelocity = new Vector3(Mathf.MoveTowards(rb.linearVelocity.x,SpeedGoalForward,ForwardAcceleration*Time.fixedDeltaTime), rb.linearVelocity.y, rb.linearVelocity.z*friction);
        rb.AddForce(new Vector3(0, 0, HorizontalMoveSpeed * Movement));      
    }
    public void OnPlayerDeath()
    {
        Time.timeScale = 0;
        AffichageScoreFinalNoir.text = Mathf.Ceil(Score).ToString();
        AffichageScoreFinalDore.text = Mathf.Ceil(ScoreDore).ToString();
        AffichageScoreFinalRouge.text = Mathf.Ceil(ScoreRouge).ToString();
        mr.enabled = false;
        ScoreUI.enabled = false;
        ecranfin.enabled = true;
        isAlive = false;
    }
}
