using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttoncall : MonoBehaviour
{
    public float dmg = 1;
   
    bool dmg1 = false;
    SerializeField dmg_1;

    bool dmg2 = false;
    SerializeField dmg_2;

    bool dmg3 = false;
    SerializeField dmg_3;

    bool dmg4 = false;
    SerializeField dmg_4;

    bool dmg5 = false;
    SerializeField dmg_5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void upgrade()
    {
        if (dmg1 == true)
        {
            dmg = 2;
        }
        if (dmg2 == true)
        {
            dmg = 3;
            dmg1 = false;
        }
        if (dmg3 == true)
        {
            dmg = 5;
            dmg2 = false;
        }
        if (dmg4 == true)
        {
            dmg = 7;
            dmg3 = false;
        }
        if (dmg5 == true)
        {
            dmg = 10;
            dmg4 = false;
        }
    }
    public void OnMouseDown()
    {
     //   if (OnMouseDown && (GetComponent<mineral>().oreCurrency >= 10))
        {
            GetComponent<mineral>().oreCurrency -= 10;
           
            dmg1 = true;
            
        }
    }
}
