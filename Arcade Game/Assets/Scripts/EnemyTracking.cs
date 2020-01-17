/*
By: Noah Cobb
Date: 1/17/2020
Description: Script for simple AI tracking
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTracking : MonoBehaviour
{
    public GameObject Target;
    Rigidbody2D myRB;
    public float ChaseSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        Target = FindObjectOfType<PlayerController>().gameObject;
        myRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Target != null)
        {
            Vector3 toTarget = Target.transform.position - transform.position;
            Track(toTarget);
        }
    
    }
    void Track(Vector3 toTarget)
    {
        myRB.velocity = toTarget.normalized * ChaseSpeed;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Destroy(collision.gameObject);
        }
    }
}
