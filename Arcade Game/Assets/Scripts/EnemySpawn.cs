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
    public GameObject enemy;
    public GameObject warning;
    float timer = 0;
    float spawnTimer = 0;
    public float startingCooldown = 5;
    public float startingSpawnCooldown = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //count the seconds until the next enemy spawn
        timer += Time.deltaTime;
        if(timer >= startingCooldown)
        {
            Instantiate(warning, new Vector3(Random.Range(-8.5f, 8.5f), Random.Range(-4.5f, 4.5f), 0), Quaternion.identity);
            while(spawnTimer < startingSpawnCooldown)
            {
                //display a warning image at the location of the enemy spawn while starting another timer
                spawnTimer += Time.deltaTime;
            }
            //once timer ends, destroy the warning message and spawn the enemy
            Instantiate(enemy, new Vector3(warning.transform.position.x, warning.transform.position.y, 0), Quaternion.identity);
            Destroy(warning);
            timer = 0;
            spawnTimer = 0;
        }
    }
}
