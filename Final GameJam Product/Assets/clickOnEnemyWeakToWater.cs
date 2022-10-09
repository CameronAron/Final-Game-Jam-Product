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
    public float edmg = 0f;

    private void Start()
    {
        enemyCurrentHealth = enemyMaxHealth;
    }

    private void Update()
    {
        //Debug.Log(enemyCurrentHealth);
        if (enemyCurrentHealth < 1)
        {
            FindObjectOfType<mineral>().leafCurrency += (Random.Range(1, 3));
            Destroy(gameObject);
        }
    }
    public void OnMouseDown()
    {
        buttoncall buttonCall = FindObjectOfType<buttoncall>();
        if (script.whatCursor == "water")
        {
            enemyCurrentHealth -= 3 * weakDamage;
        }
        else
        {
            enemyCurrentHealth -= weakDamage;
            //Debug.Log(script.whatCursor + " is the cursor currently selected");
        }

    }
    }

    
