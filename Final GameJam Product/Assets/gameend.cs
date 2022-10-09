using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameend : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("insta", 0, 15);
    }

    // Update is called once per frame
    void Update()
    {
       
       if (FindObjectOfType<mineral>().ageCurrency >= 100)
        {
            SceneManager.LoadScene("End");
        }
    }
    public void insta()
    {
     //   Instantiate(reasourcetree, new Vector3( 2.0f, 0, 0), Quaternion.identity);
    }
}
