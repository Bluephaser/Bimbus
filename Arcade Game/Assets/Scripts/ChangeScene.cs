using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    public GameObject Player;
    public string SceneChange = "EndScreen";

    // Start is called before the first frame update
    void Start()
    {
        Player = FindObjectOfType<PlayerController>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player == null)
        {
            LoadScene();
        }


    }

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneChange);
    }

}
