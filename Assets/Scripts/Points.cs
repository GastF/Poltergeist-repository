using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public int puntos;
    public Text txt;
    public int curr;
    int prev;
    bool combo;

    private void Update()
    {
        //Muestra los puntos
        txt.text = "Puntos: " + puntos;

        //Activa el combo
        if (prev < curr + 1)
        {
            combo = true;
            prev = curr;
        }

        //Desactiva el combo
        if (curr < prev)
        {
            combo = false;
            curr = 0;
        }
    }

    //Suma puntos
    public void PointUp(int i)
    {
        //Multiplicador de puntos
        if (combo == true)
        {
            puntos += i * curr;
        }
        
        puntos += i;
    }
}
