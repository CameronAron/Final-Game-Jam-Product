using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickOnEnemyWeakToWater : MonoBehaviour
{
    public CursorManager script;
    public float enemyMaxHealth = 20f;
    public float enemyCurrentHealth;
    public float weakDamage = 1f;
    public float strongDamage = 5f;

    private void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
    }


    void OnMouseDown()
    {
        if (script.whatCursor == "water")
        {
            enemyCurrentHealth = enemyCurrentHealth - strongDamage;
        }
        else
        {
            enemyCurrentHealth = enemyCurrentHealth - weakDamage;
        }
        //Debug.Log(script.whatCursor + " is the cursor currently selected");
    }

    private void Update()
    {
        //Debug.Log(enemyCurrentHealth);
        if (enemyCurrentHealth < 1)
        {
            Destroy(gameObject);
        }
    }

}
