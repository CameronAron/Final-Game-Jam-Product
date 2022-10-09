using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clickOnItem : MonoBehaviour
{
    public CursorManager script;

    Vector2 pos;
    float x;
    float y;
    public void Start()
    {
        Invoke("destory", 10);
        x = Random.Range(-38, 38);
        y = Random.Range(-16, 16);

        pos = new Vector2(x, y);
        transform.position = pos;
    }


   public void OnMouseDown()
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
        Destroy(gameObject);
    }
    private void Update()
    {

    }

}
