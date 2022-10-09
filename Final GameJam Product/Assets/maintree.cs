using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maintree : MonoBehaviour
{
    float tree1;
    SerializeField tree2;
    SerializeField tree3;


    public float agen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    agen = GetComponent<mineral>().ageCurrency;

    }
}
