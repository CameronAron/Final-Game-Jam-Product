using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mineral : MonoBehaviour
{
    float oreCurrency = 0;
    public float OCT = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(oreCurrency);
        currencychange();
    }
    void currencychange()
    {

        oreCurrency += 1;


        if (OCT == 1)
        {
            oreCurrency += 1;
        }

        if (OCT == 2)
        {
            oreCurrency += 3;
        }

        if (OCT == 3)
        {
            oreCurrency += 5;
        }

    }
}
