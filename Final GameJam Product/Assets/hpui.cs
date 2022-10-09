using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class hpui : MonoBehaviour
{
    public mineral treehp;
    public TextMeshProUGUI text;
    //
    float treehpp = 10;

    //    public Text ValueText;


    private void Update()
    {
        //       ValueText.text = Value.ToString();
        treehpp = treehp.thp;
        text.text = treehpp.ToString();


    }
}