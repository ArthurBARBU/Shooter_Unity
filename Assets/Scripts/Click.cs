using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ModifieText : MonoBehaviour
{
    public TextMeshProUGUI monUI;
    public int nombreDeFoisCliqu�;


    private void Start()
    {
    }

    private void OnMouseDown()
    {
        nombreDeFoisCliqu�++;
        monUI.text = "On m'as cliqu� " + nombreDeFoisCliqu�;
    }

}
