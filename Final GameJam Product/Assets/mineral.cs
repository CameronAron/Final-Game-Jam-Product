using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mineral : MonoBehaviour
{
   public float ageCurrency = 0;
    
   public float oreCurrency = 1;
    public float OCT = 0;
    public float Ops = 0;

   public  float leafCurrency = 1;
    public float LCT = 0;
    public float Lps = 0;

    public float thp = 10;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("currencychangeage", 0, 10f);
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
        thp += 0.1f * (ageCurrency / 10);
        // tree regeneration = 0.1 hp /sec * age/10
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
       
        Debug.Log(leafCurrency+" leaf");

        Debug.Log(ageCurrency + " age");
    }
    void currencychangeage()
    {
        ageCurrency +=1;
    }
    void currencychangeleaf()
    {

        leafCurrency += Lps;


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