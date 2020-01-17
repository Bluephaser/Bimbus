using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointSystem : MonoBehaviour
{
    float timer = 0;
    
    public Text ScoreText;
    //public Text EndScore;
    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().name == "Level 1")
            GameManager.Score = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleScore();
        timer += Time.deltaTime;
        
        if(timer >= 5)
        {
            ++GameManager.Score;
            timer = 0;
        }
    }
    private void HandleScore()
    {
        if (ScoreText != null)
            ScoreText.text = "Player Score: " + GameManager.Score;

        //if(EndScore != null)
            //EndScore.text = "Final Score: " + currentScore;
    }
}
