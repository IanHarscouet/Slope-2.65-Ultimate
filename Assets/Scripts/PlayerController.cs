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
    public TextMeshProUGUI AffichageScore;
    public TextMeshProUGUI AffichageScoreDore;
    public TextMeshProUGUI AffichageScoreRouge;
    public float Score;
    public float ScoreDore;
    public float ScoreRouge;
    public bool isAlive;
    
    
    public void Start()
    {
          
        isAlive = true;
        Time.timeScale = 1;
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
        mr.enabled = false;
        ecranfin.enabled = true;
        isAlive = false;
    }
}
