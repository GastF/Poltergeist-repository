using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Power : MonoBehaviour
{
    public Text txt;
    public int limit; //Limite de energía
    public float pwr; //Energía actual

    private void Update()
    {
        txt.text = "Power: " + pwr;

        //Carga de energía
        if (pwr < limit)
        {
            pwr += Time.deltaTime / 2;
        }
    }
}
