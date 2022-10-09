using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treehit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //      FindObjectOfType<mineral>().thp -= FindObjectOfType<enemyMovement>().edmg;
        if (collision.collider.tag == "bird")
        { 
      //  thp -= edmg
        }
    }
}
// gameobject.FindGameObjectsWithTag