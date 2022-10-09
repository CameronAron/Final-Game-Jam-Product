using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttoncall : MonoBehaviour
{
    public float Dmg = 11;
    private mineral cur;
    
   
    // Start is called before the first frame update
    void Start()
    {
        cur = FindObjectOfType<mineral>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
    
    }
    public void Dmgup()
    {
    
        {
            if (cur.leafCurrency >= 10 && cur.oreCurrency >= 10)
            {
                Dmg += 1;
                cur.leafCurrency -= 10;
                cur.oreCurrency -= 10;
               
            }
        }
    }
    public void Leafup()
    {
   
        {
            if (cur.leafCurrency >= 20)
            {
                cur.leafCurrency -= 20;
                cur.Lps += 0.09f;
            }
        }
          
    }
    public void Oreup()
    {
  
        {
            if (cur.oreCurrency >= 25)
            {

                cur.oreCurrency -= 25;
                cur.Ops += 0.09f;

            }
        }
    }
  
     
  
}
