using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTracking : MonoBehaviour
{
    public GameObject Target;
    public int EnemySpeed;
    public int RotationSpeed;
    Rigidbody2D myRB;
    public float ChaseSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        Target = FindObjectOfType<PlayerController>().gameObject; 

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
}
