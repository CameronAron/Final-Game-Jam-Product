using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class lifeui : MonoBehaviour
{
    public mineral mineral;
    public TextMeshProUGUI text;
//
    float life = 0;
    
//    public Text ValueText;
    
        
    private void Update()
    {
        //       ValueText.text = Value.ToString();
        life = mineral.ageCurrency;
        text.text = life.ToString();


    }
}
//GetComponent<mineral>().ageCurrency;


//