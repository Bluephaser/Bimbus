/*GameManager.cs
 * By: Noah Cobb
 * Last edited: 1/6/2020
 * Description: Handles game states, and game variables
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Game variables

    public static int Score = 0;
    

    

    

    
    //singleton implementation
    private static GameManager _instance;
    //class constructor
    public static GameManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<GameManager>();
                DontDestroyOnLoad(_instance.gameObject);
            }
            return _instance;
        }
    }
    //Awake happens before even start does
    private void Awake()
    {
        //if first game manager set as our main instance
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
        //if not destroy imposter
        else if (this != _instance)
        {
            Destroy(this);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
