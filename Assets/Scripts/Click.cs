using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ModifieText : MonoBehaviour
{
    public TextMeshProUGUI monUI;
    public int nombreDeFoisCliqué;


    private void Start()
    {
    }

    private void OnMouseDown()
    {
        nombreDeFoisCliqué++;
        monUI.text = "On m'as cliqué " + nombreDeFoisCliqué;
    }

}
