using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunEnemyHealthBar : MonoBehaviour
{

    public clickOnEnemyWeakToSun script;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(script.enemyCurrentHealth / script.enemyMaxHealth, transform.localScale.y, transform.localScale.z);
    }
}
