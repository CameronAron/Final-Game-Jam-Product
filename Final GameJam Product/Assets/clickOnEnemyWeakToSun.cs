using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickOnEnemyWeakToSun : MonoBehaviour
{
    public CursorManager script;
    public float enemyHealth = 20f;

    void OnMouseDown()
    {
        if (script.whatCursor == "sun")
        {
            enemyHealth = enemyHealth - 5;
        }
        else
        {
            enemyHealth = enemyHealth - 1;
        }
        //Debug.Log(script.whatCursor + " is the cursor currently selected");
    }

    private void Update()
    {
        Debug.Log(enemyHealth);
        if (enemyHealth < 1)
        {
            Destroy(gameObject);
        }
    }

}
