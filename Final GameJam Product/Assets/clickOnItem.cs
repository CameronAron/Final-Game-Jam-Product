using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickOnItem : MonoBehaviour
{
    public CursorManager script;

    private void Start()
    {

    }


    void OnMouseDown()
    {
        if (script.whatCursor == "default")
        {
            Destroy(gameObject);
        }

        //Debug.Log(script.whatCursor + " is the cursor currently selected");
    }

    private void Update()
    {

    }

}
