using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snailCountDown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Object.Destroy(gameObject, 10.25f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
