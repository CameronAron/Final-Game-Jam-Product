using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public GameObject target;
    public float speed = .1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("enemymove", 0, .5f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enemymove()
    {
        Vector3 a = transform.position;
        Vector3 b = target.transform.position;
        transform.position = Vector3.MoveTowards(a, b, speed);
    }
}
