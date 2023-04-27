using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public Light luzDeLaHabitacion;

    private bool luzEncendida = false;

    private void OnMouseDown()
    {
        luzEncendida = !luzEncendida;
        luzDeLaHabitacion.enabled = luzEncendida;
    }
}
