/*
 FinalScore.cs
 Created by: Liam Binford
 Description: Finds the score at the end of the game and displays it
 Date: 1/17/20
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalScore : MonoBehaviour
{
    public Text FinalScoreText;
    // Start is called before the first frame update
    void Start()
    {
        //works only if the level is endscreen
        if(SceneManager.GetActiveScene().name == "EndScreen")
        {
            //show final score
            FinalScoreText.text = "Final Score: " + GameManager.Score;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
