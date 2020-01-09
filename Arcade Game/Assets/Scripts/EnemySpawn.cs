/*
 EnemySpawn.cs
 By: Liam Binford
 Last Edited: 1/9/20
 Description: Chooses a random spot for the enemy to spawn, then flashes a warning for a moment and spawns them.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawn : MonoBehaviour
{
    float timer = 0;
    public float startingCooldown = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= startingCooldown)
        {

        }
    }
}
