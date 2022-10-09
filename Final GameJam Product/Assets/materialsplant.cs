using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materialsplant : MonoBehaviour
{
    Vector2 pos;
    float x;
        float y;
    // Start is called before the first frame update
    void Start()
    {
        x = Random.Range(1, 100);
        y = Random.Range(1, 100);
       
        pos = new Vector2 (x,y);
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        GetComponent<mineral>().leafCurrency += 10;
       
        Destroy(gameObject);
    }
}
// add scavanger level