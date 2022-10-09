using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickOnEnemyWeakToSun : MonoBehaviour
{
    public CursorManager script;
    public float enemyMaxHealth = 20f;
    public float enemyCurrentHealth;
    public float weakDamage = 1f;
    public float strongDamage = 5f;
    public float edmg = 0f;


    private void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
    }
    

    void OnMouseDown()
    {
        if (script.whatCursor == "sun")
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
