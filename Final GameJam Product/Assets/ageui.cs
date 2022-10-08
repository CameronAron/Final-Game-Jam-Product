using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ageui : MonoBehaviour
{
    public mineral age;
    public TextMeshProUGUI text;
    //
    float aage = 0;

    //    public Text ValueText;


    private void Update()
    {
        //       ValueText.text = Value.ToString();
        aage = age.ageCurrency;
        text.text = aage.ToString();


    }
}
//GetComponent<mineral>().ageCurrency;


//