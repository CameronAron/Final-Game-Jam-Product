using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttoncall : MonoBehaviour
{
    public float dmg = 1;

    
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Dmgup();
        Leafup();
        Oreup();
    }
    public void Dmgup()
    {
     //   if (CompareTag == dmgtag)
        {
            if (FindObjectOfType<mineral>().leafCurrency >= 10 && FindObjectOfType<mineral>().oreCurrency >= 10)
            {
                dmg += 1;
                FindObjectOfType<mineral>().leafCurrency -= 10;
                FindObjectOfType<mineral>().oreCurrency -= 10;
               
            }
        }
    }
    public void Leafup()
    {
      //  if (leaftag)
        {
            if (FindObjectOfType<mineral>().leafCurrency >= 20)
            {
                FindObjectOfType<mineral>().leafCurrency -= 20;
                FindObjectOfType<mineral>().Lps += 0.05f;
            }
        }
          
    }
    public void Oreup()
    {
      //  if (oretag == tag)
        {
            if (FindObjectOfType<mineral>().oreCurrency >= 25)
            {

                FindObjectOfType<mineral>().oreCurrency -= 25;
                FindObjectOfType<mineral>().Ops += 0.05f;

            }
        }
    }
  
     
  
}
