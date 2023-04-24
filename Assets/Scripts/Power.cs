using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Power : MonoBehaviour
{
    public Text txt;
    public int limit; //Limite de energ�a
    public float pwr; //Energ�a actual

    private void Update()
    {
        txt.text = "Power: " + pwr;

        //Carga de energ�a
        if (pwr < limit)
        {
            pwr += Time.deltaTime / 2;
        }
    }
}
