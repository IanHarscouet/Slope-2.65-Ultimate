using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;


public class PlayerController : MonoBehaviour
{
    public float HorizontalMoveSpeed;
    public float Movement;
    public Rigidbody rb;
    public float Speed;
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
        rb.linearVelocity = new Vector3(Speed, rb.linearVelocity.y, rb.linearVelocity.z);
        rb.AddForce(new Vector3(0, 0, Movement * HorizontalMoveSpeed));
             
    }
    public void OnPlayerDeath()
    {
        Time.timeScale = 0;
        mr.enabled = false;
        ecranfin.enabled = true;
        isAlive = false;
    }
}
