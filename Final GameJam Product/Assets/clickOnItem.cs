using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickOnItem : MonoBehaviour
{
    public CursorManager script;

    Vector2 pos;
    float x;
    float y;
    private void Start()
    {
     //  Instantiate<destroy>()
        x = Random.Range(-38, 38);
        y = Random.Range(-16, 16);

        pos = new Vector2(x, y);
        transform.position = pos;
    }


    void OnMouseDown()
    {
        if (script.whatCursor == "default")
        {
            FindObjectOfType<mineral>().leafCurrency += 10;
            Destroy(gameObject);

            
           
        }

        //Debug.Log(script.whatCursor + " is the cursor currently selected");
    }
    void destory()
    { 
    
    }
    private void Update()
    {

    }

}
