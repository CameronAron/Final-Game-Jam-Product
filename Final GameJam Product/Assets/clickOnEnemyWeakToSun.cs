using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickOnEnemyWeakToSun : MonoBehaviour
{
    public CursorManager script;

    void OnMouseDown()
    {
        if (script.whatCursor == "sun")
        {
            Destroy(gameObject);
        }
        //Debug.Log(script.whatCursor + " is the cursor currently selected");
    }

}
