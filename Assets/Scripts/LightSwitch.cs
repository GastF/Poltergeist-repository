using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public Light luzDeLaHabitacion;

    public Power pwr;
    public Points pnts;

    private bool luzEncendida = false;

    private void Start()
    {
        pwr = FindObjectOfType<Power>();
        pnts = FindObjectOfType<Points>();
    }

    private void OnMouseDown()
    {
        if (pwr.pwr >= 1)
        {
            luzEncendida = !luzEncendida;
            luzDeLaHabitacion.enabled = luzEncendida;
            pwr.pwr -= 1;
            pnts.puntos += 125;
        }
    }
}
