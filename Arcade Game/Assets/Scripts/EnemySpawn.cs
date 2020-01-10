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

    IEnumerator DestroyAfterTime(GameObject toDestroy, float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Destroy(toDestroy);
    }

    IEnumerator CreateAfterTime(GameObject toCreate, float seconds, Vector3 spawnPos)
    {
        yield return new WaitForSeconds(seconds);
        Instantiate(toCreate, spawnPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Random.Range(-8.5f, 8.5f);
        float yAxis = Random.Range(-4.5f, 4.5f);
        //count the seconds until the next enemy spawn
        timer += Time.deltaTime;
        if(timer >= startingCooldown)
        {
            GameObject warningCopy = Instantiate(warning, new Vector3(xAxis, yAxis, 0), Quaternion.identity);

            StartCoroutine(DestroyAfterTime(warningCopy, 3.0f));

            //once timer ends, destroy the warning message and spawn the enemy
            StartCoroutine(CreateAfterTime(enemy, 3, new Vector3(xAxis, yAxis, 0)));
            timer = 0;
            spawnTimer = 0;
        }
    }

}
