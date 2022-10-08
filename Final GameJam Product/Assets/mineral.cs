using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mineral : MonoBehaviour
{
    float oreCurrency = 0;
    public float OCT = 0;
    public float Ops = 0;

    float leafCurrency = 0;
    public float LCT = 0;
    public float Lps = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("currencychangeore", 0, 1f);
        InvokeRepeating("currencychangeleaf", 0, 1f);
        InvokeRepeating("callcurrency", 0, 1f);
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            OCT += 1;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            LCT += 1;
        }
    }
    void currencychangeore()
    {

        oreCurrency += Ops;


        if (OCT == 1)
        {
            Ops = 1;
        }

        if (OCT == 2)
        {
            Ops = 3;
        }

        if (OCT == 5) 
        {
            Ops = 5;
        }

    }
    void callcurrency()
    {
        Debug.Log(oreCurrency+" ore");
       
        Debug.Log(oreCurrency+" leaf");
       
    }
    void currencychangeleaf()
    {

        oreCurrency += Lps;


        if (LCT == 1)
        {
            Lps = 1;
        }

        if (LCT == 2)
        {
            Lps = 3;
        }

        if (LCT == 3)
        {
            Lps = 5;
        }
       
    }
}
// Oct= ore current tier
// Ops = ore per sec
// Lct = leaf current tier
// Lps = leaf per second