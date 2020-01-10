using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    float timer = 0;
    private int currentScore;
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        currentScore = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleScore();
        timer += Time.deltaTime;
        
        if(timer >= 5)
        {
            ++currentScore;
            timer = 0;
        }
    }
    private void HandleScore()
    {
        ScoreText.text = "Player Score: " + currentScore;
    }
}
