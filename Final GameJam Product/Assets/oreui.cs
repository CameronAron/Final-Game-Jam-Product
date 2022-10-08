using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class oreui : MonoBehaviour
{
    public mineral ore;
    public TextMeshProUGUI text;
    //
    float oree = 0;

    //    public Text ValueText;


    private void Update()
    {
        //       ValueText.text = Value.ToString();
        oree = ore.oreCurrency;
        text.text = oree.ToString();


    }
}
//GetComponent<mineral>().ageCurrency;


//